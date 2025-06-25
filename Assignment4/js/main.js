var emailElement = document.getElementById("userEmail");
var passElement = document.getElementById("userPassword");
var loginSection = document.getElementById("loginSection");
var signupSection = document.getElementById("signupSection");
var showSignup = document.getElementById("showSignup");
var showLogin = document.getElementById("showLogin");

var signupName = document.getElementById("signupName");
var signupEmail = document.getElementById("signupEmail");
var signupPassword = document.getElementById("signupPassword");

var signupNameError = document.getElementById("signupNameError");
var signupEmailError = document.getElementById("signupEmailError");
var signupPasswordError = document.getElementById("signupPasswordError");

var signupBtn = document.getElementById("signupBtn");

var userRegex = {
  userEmailRegex: /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/,
  userPasswordRegex: /^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$/,  // at least 8 chars, 1 letter, 1 digit
  userNameRegex: /^[A-Za-z]{3,}$/
};

function isUserValid(regex, user) {
  const errorElement = user.parentElement.querySelector("p");

  if (regex.test(user.value.trim())) {
    user.classList.remove("is-invalid");
    user.classList.add("is-valid");
    if (errorElement) errorElement.classList.replace("d-block", "d-none");
    return true;
  } else {
    user.classList.remove("is-valid");
    user.classList.add("is-invalid");
    if (errorElement) errorElement.classList.replace("d-none", "d-block");
    return false;
  }
}


emailElement.addEventListener("input", function () {
  isUserValid(userRegex.userEmailRegex, emailElement);
});

passElement.addEventListener("input", function () {
  isUserValid(userRegex.userPasswordRegex, passElement);
});

document.getElementById("addBtn").addEventListener("click", function () {
  var validEmail = isUserValid(userRegex.userEmailRegex, emailElement);
  var validPass = isUserValid(userRegex.userPasswordRegex, passElement);

  if (validEmail && validPass) {
    var users = JSON.parse(localStorage.getItem("users")) || [];

    var matchedUser = users.find(
      user =>
        user.email === emailElement.value.trim().toLowerCase() &&
        user.password === passElement.value
    );

    if (matchedUser) {
      // Save logged in user name to memory (or sessionStorage)
      localStorage.setItem("loggedInUser", matchedUser.name);

      // Show Home Section
      document.getElementById("loginSection").classList.add("d-none");
      document.getElementById("signupSection").classList.add("d-none");
      document.getElementById("homeSection").classList.remove("d-none");

      document.getElementById("usernameDisplay").textContent = matchedUser.name;
    } else {
      alert("Incorrect email or password");
    }
  } else {
    alert("Please fix errors before submitting");
  }
});


showSignup.addEventListener("click", function (e) {
  e.preventDefault();
  loginSection.classList.add("d-none");
  signupSection.classList.remove("d-none");
});

showLogin.addEventListener("click", function (e) {
  e.preventDefault();
  resetSignupForm();
  signupSection.classList.add("d-none");
  loginSection.classList.remove("d-none");
});

signupName.addEventListener("input", function () {
  isUserValid(userRegex.userNameRegex, signupName);
});

signupEmail.addEventListener("input", function () {
  isUserValid(userRegex.userEmailRegex, signupEmail);
});

signupPassword.addEventListener("input", function () {
  isUserValid(userRegex.userPasswordRegex, signupPassword);
});

signupBtn.addEventListener("click", function () {
  var validName = isUserValid(userRegex.userNameRegex, signupName);
  var validEmail = isUserValid(userRegex.userEmailRegex, signupEmail);
  var validPassword = isUserValid(userRegex.userPasswordRegex, signupPassword);

  if (validName && validEmail && validPassword) {
    var users = JSON.parse(localStorage.getItem("users")) || [];

    // check for duplicate email
    var existingUser = users.find(function (user) {
      return user.email === signupEmail.value;
    });


    if (existingUser) {
      signupEmail.classList.remove("is-valid");
      signupEmail.classList.add("is-invalid");
      signupEmailError.textContent = "Email already registered";
      signupEmailError.classList.replace("d-none", "d-block");
      return;
    }

    // store user
    var newUser = {
      name: signupName.value.trim(),
      email: signupEmail.value.trim().toLowerCase(),
      password: signupPassword.value
    };

    users.push(newUser);
    localStorage.setItem("users", JSON.stringify(users));

    alert("Sign up successful! You can now log in.");

    // Reset form
    signupName.value = "";
    signupEmail.value = "";
    signupPassword.value = "";
    signupName.classList.remove("is-valid");
    signupEmail.classList.remove("is-valid");
    signupPassword.classList.remove("is-valid");

    // Show login form
    signupSection.classList.add("d-none");
    loginSection.classList.remove("d-none");
  } else {
    alert("Please fix all errors before signing up.");
  }
});

document.getElementById("logoutBtn").addEventListener("click", function () {
  localStorage.removeItem("loggedInUser");

  document.getElementById("homeSection").classList.add("d-none");
  document.getElementById("loginSection").classList.remove("d-none");
});

function resetSignupForm() {
  signupName.value = "";
  signupEmail.value = "";
  signupPassword.value = "";

  // Clear classes
  signupName.classList.remove("is-valid", "is-invalid");
  signupEmail.classList.remove("is-valid", "is-invalid");
  signupPassword.classList.remove("is-valid", "is-invalid");
  signupNameError.classList.add("d-none");
  signupEmailError.classList.add("d-none");
  signupPasswordError.classList.add("d-none");


  // Hide error messages
  document.getElementById("nameError").classList.add("d-none");
  document.getElementById("emailError").classList.add("d-none");
  document.getElementById("passwordError").classList.add("d-none");
}
