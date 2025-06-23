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
    validationAlert.classList.add("hidden");
  } else {
    validationAlert.classList.remove("hidden");
  }
};

// Validate URL
function isValidURL(url) {
  var pattern = /^(https?:\/\/)?(www\.)?[a-zA-Z0-9-]{2,}(\.[a-zA-Z]{2,})+(\/[^\s]*)?$/;
  return pattern.test(url.trim());
}

// Validate Site Name (≥ 3 chars)
function isValidName(name) {
  return name.trim().length >= 3;
}

// Whole form check
function validateForm() {
  return isValidName(siteNameInput.value) && isValidURL(siteURLInput.value);
}

// Live name check
function validateSiteName() {
  var valid = isValidName(siteNameInput.value);
  siteNameInput.classList.remove("is-valid", "is-invalid");
  siteNameInput.classList.add(valid ? "is-valid" : "is-invalid");
}

// Live URL check
function validateSiteURL() {
  var valid = isValidURL(siteURLInput.value);
  siteURLInput.classList.remove("is-valid", "is-invalid");
  siteURLInput.classList.add(valid ? "is-valid" : "is-invalid");
}

// Close modal
function closeValidationAlert() {
  validationAlert.classList.add("hidden");
}

// Add bookmark with ensured https://
function addBookmark() {
  var rawURL = siteURLInput.value.trim();
  var finalURL = rawURL.match(/^https?:\/\//) ? rawURL : 'https://' + rawURL;

  var bookmark = {
    name: siteNameInput.value.trim(),
    url: finalURL
  };

  bookmarkList.push(bookmark);
  saveBookmarks();
  displayBookmarks();
  clearInputs();
}

// Update bookmark with ensured https://
function updateBookmark() {
  if (updateIndex !== null) {
    var rawURL = siteURLInput.value.trim();
    var finalURL = rawURL.match(/^https?:\/\//) ? rawURL : 'https://' + rawURL;

    bookmarkList[updateIndex].name = siteNameInput.value.trim();
    bookmarkList[updateIndex].url = finalURL;

    saveBookmarks();
    displayBookmarks();
    clearInputs();
  }
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
  siteNameInput.classList.remove("is-valid", "is-invalid");
  siteURLInput.classList.remove("is-valid", "is-invalid");
  updateIndex = null;
}