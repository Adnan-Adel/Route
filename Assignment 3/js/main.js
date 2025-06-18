// Get input elements
var siteNameInput = document.getElementById("siteName");
var siteURLInput = document.getElementById("siteURL");
var submitBtn = document.getElementById("submitBtn");
var validationAlert = document.getElementById("validationAlert");

var bookmarkList = [];
var updateIndex = null;

// Load bookmarks if exist
if (localStorage.getItem("bookmarks")) {
  bookmarkList = JSON.parse(localStorage.getItem("bookmarks"));
  displayBookmarks();
}

// Add or Update on click
submitBtn.onclick = function () {
  if (validateForm()) {
    if (updateIndex === null) {
      addBookmark();
    } else {
      updateBookmark();
    }
    // Hide the alert if visible
    validationAlert.classList.add("hidden");
  } else {
    // Show the custom modal
    validationAlert.classList.remove("hidden");
  }
};



// Validate Site Name (≥ 3 chars)
function isValidName(name) {
  return name.trim().length >= 3;
}

// Validate URL (simple regex for http(s)://... )
function isValidURL(url) {
  var pattern = /^(https?:\/\/)[^\s$.?#].[^\s]*$/gm;
  return pattern.test(url.trim());
}

// Check whole form before adding
function validateForm() {
  var nameValid = isValidName(siteNameInput.value);
  var urlValid = isValidURL(siteURLInput.value);

  return nameValid && urlValid;
}


// Live check for Site Name
function validateSiteName() {
  var nameValid = isValidName(siteNameInput.value);
  siteNameInput.classList.remove("is-valid", "is-invalid");
  siteNameInput.classList.add(nameValid ? "is-valid" : "is-invalid");
}

// Live check for Site URL
function validateSiteURL() {
  var urlValid = isValidURL(siteURLInput.value);
  siteURLInput.classList.remove("is-valid", "is-invalid");
  siteURLInput.classList.add(urlValid ? "is-valid" : "is-invalid");
}

// Function to close the modal
function closeValidationAlert() {
  validationAlert.classList.add("hidden");
}

// Add new bookmark
function addBookmark() {
  var bookmark = {
    name: siteNameInput.value,
    url: siteURLInput.value
  };

  bookmarkList.push(bookmark);
  saveBookmarks();
  displayBookmarks();
  clearInputs();
}

// Display bookmarks
function displayBookmarks() {
  var rows = "";
  for (var i = 0; i < bookmarkList.length; i++) {
    rows += `
      <tr>
        <td>${i + 1}</td>
        <td>${bookmarkList[i].name}</td>
        <td>
          <a href="${bookmarkList[i].url}" target="_blank" class="btn btn-visit">
            <i class="fa-solid fa-eye"></i> Visit
          </a>
        </td>
        <td>
          <button onclick="deleteBookmark(${i})" class="btn btn-delete">
            <i class="fa-solid fa-trash"></i> Delete
          </button>
        </td>
      </tr>`;
  }
  document.getElementById("tableBody").innerHTML = rows;
}

// Save to localStorage
function saveBookmarks() {
  localStorage.setItem("bookmarks", JSON.stringify(bookmarkList));
}

// Delete bookmark
function deleteBookmark(index) {
  bookmarkList.splice(index, 1);
  saveBookmarks();
  displayBookmarks();
}

// Clear form
function clearInputs() {
  siteNameInput.value = "";
  siteURLInput.value = "";
  updateIndex = null;
  siteNameInput.classList.remove("is-valid", "is-invalid");
  siteURLInput.classList.remove("is-valid", "is-invalid");
  updateIndex = null;
}