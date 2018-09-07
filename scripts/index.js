/**
 * 添加个性化的欢迎信息
 */
var myButton = document.querySelector('button');
var myHeading = document.querySelector('h1');
function SetUserName() {
    var myName=prompt('Please enter your name.');
    localStorage.setItem('name',myName);
    myHeading.textContent='Hi,'+myName;
  }
  if(!localStorage.getItem('name')) {
    SetUserName();
  } else {
    var storedName = localStorage.getItem('name');
    myHeading.textContent = 'Mozilla is cool, ' + storedName;
  }
  myButton.onclick = function() {
    SetUserName();
  }
