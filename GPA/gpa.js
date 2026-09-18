console.log("\t GPA");
const math = Number(prompt("Math : "))
if (math>100 || math<0){console.log("enter correct number"); return;}
const english = Number(prompt("english : ")) 
if (english>100 || english<0){console.log("enter correct number"); return;}
const physics = Number(prompt("physics : "))
if (physics>100 || physics<0){console.log("enter correct number"); return;}
const chemistry = Number(prompt("chemistry : "))
if (chemistry>100 || chemistry<0){console.log("enter correct number"); return;}
const biology = Number(prompt("biology : "))
if (biology>100 || biology<0){console.log("enter correct number"); return;}
const total = math + english + physics + chemistry + biology; console.log( "total : " + total) 
const average = total/5; 
console.log("average : "+ average) 
if (average>=90 && average<=100){console.log("A")} 
else if (average>=80 && average<90){console.log("B")} 
else if (average>=70 && average<80){console.log("C")} 
else if (average>=60 && average<70){console.log("D")} 
else if (average>=50 && average<60){console.log("D-")}
else {console.log("F")}