// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


const darkNavbar = "navbar navbar-fixed-top navbar-expand navbar-dark bg-dark";
const lightNavbar = "navbar navbar-fixed-top navbar-expand navbar-light bg-light";

window.onload = setThemeFromLocalStorage();

document.getElementById("darkModeToggle").addEventListener('click', toggleDarkMode)

let isDarkMode = window.matchMedia('(prefers-color-scheme: dark)').matches;



let darkModeStyle = "bg-dark text-white";
let lightMode = "bg-white";


function toggleDarkMode(isDark) {
    let bodyStyle = document.body.style;
    let bodyClassList = [...document.body.classList];
    if (bodyClassList[0] === "midnight") {
        setTheme("light");
    }
    else {
        setTheme("dark");
    }
   
}


function updateToggleText(text) {
    document.getElementById("darkModeToggle").classList = text;
}


function setTheme(theme) {
    let bodyClassList = [...document.body.classList];
    if (theme === "light") {
        bodyClassList[0] = "daytime";
        document.getElementsByTagName("nav")[0].classList = lightNavbar;
        window.localStorage.setItem("themePreference", "light");
    }
    else {
        bodyClassList[0] = "midnight";
        document.getElementsByTagName("nav")[0].classList = darkNavbar;
        window.localStorage.setItem("themePreference", "dark");
    }
    document.body.classList = bodyClassList;
}


function setThemeFromLocalStorage() {
    let themePreference = window.localStorage.getItem("themePreference");

    if (themePreference == null || themePreference === undefined) {
        window.localStorage.setItem("themePreference", "light");
        setTheme("light");
    }
    else if (themePreference === "light") {
        setTheme("light");
    }
    else if (themePreference === "dark") {
        setTheme("dark");
    }
    console.log(window.localStorage);
}