var currentIndex = 0;
slideNow();

function slideNow() {
  var i;
  var x = document.getElementsByClassName("SlideIMG");
  for (i = 0; i < x.length; i++) {
    x[i].style.display = "none";  
  }
  currentIndex++;
  if (currentIndex > x.length) {currentIndex = 1}    
  x[currentIndex-1].style.display = "block";  
  setTimeout(slideNow, 2000);
}

var Index = 1;
showIMG(Index);

function nextIMG(n) {
  showIMG(Index += n);
}

function showIMG(n) {
  var i;
  var x = document.getElementsByClassName("SlideIMG");
  if (n > x.length) {Index = 1}
  if (n < 1) {Index = x.length}
  for (i = 0; i < x.length; i++) {
    x[i].style.display = "none";  
  }
  x[Index-1].style.display = "block";  
}