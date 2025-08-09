/* -------------------------- Question1 -------------------------- */
// var num = Number(window.prompt('Enter a number: '));
// console.log(num);

/* -------------------------- Question2 -------------------------- */
// var num  = Number(window.prompt('Enter a number: '));
// if((num % 3 == 0) && (num %4 == 0)) {
//   console.log('Yes');
// }
// else {
//   console.log('No');
// }

/* -------------------------- Question3 -------------------------- */
// var num1 = +(window.prompt('Enter first number: '));
// var num2 = +(window.prompt('Enter second number: '));

// if(num1 >= num2) {
//   console.log(num1);
// }
// else {
//   console.log(num2);
// }


/* -------------------------- Question4 -------------------------- */
// var num  = Number(window.prompt('Enter a number: '));

// if(num < 0) {
//   console.log('negative');
// }
// else {
//   console.log('positive');
// }

/* -------------------------- Question5 -------------------------- */
// var num1 = +(window.prompt('Enter first number: '));
// var num2 = +(window.prompt('Enter second number: '));
// var num3 = +(window.prompt('Enter third number: '));

// var max = num1;
// var min = num1;

// // find max number
// if((num2 > num1) && (num2 > num3)) {
//   max = num2;
// }
// else if((num3 > num1) && (num3 > num2)) {
//   max = num3
// }

// // find min number
// if((num2 < num1) && (num2 < num3)) {
//   min = num2;
// }
// else if((num3 < num1) && (num3 < num2)) {
//   min = num3
// }

// // print
// console.log('max is: ', max);
// console.log('min is: ', min);

/* -------------------------- Question6 -------------------------- */
// var num  = +(window.prompt('Enter a number: '));

// if(num % 2 == 0) {
//   console.log('even');
// }
// else {
//   console.log('odd');
// }

/* -------------------------- Question8 -------------------------- */
// var ch = window.prompt('Enter a character: ');

// if(ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' ||
//    ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' ||
//    ch == 'u' || ch == 'U') {
//     console.log('Vowel');
// }
// else {
//   console.log('Constant');
// }

/* -------------------------- Question9 -------------------------- */
// var num  = +(window.prompt('Enter a number: '));

// if(num < 1) {
//   console.log('Invalid input, enter a positive number.');
// }
// else {
//   for(var i = 1; i <= num; i++) {
//     console.log(i);
//   }
// }

/* -------------------------- Question10 -------------------------- */
// var num  = +(window.prompt('Enter a number: '));

// for(var i = 1; i <= 12; i++) {
//   console.log(num * i);
// }

/* -------------------------- Question11 -------------------------- */
// var num  = +(window.prompt('Enter a number: '));

// for(var i = 2; i <= num; i++) {
//   if(i % 2 == 0) {
//     console.log(i);
//   }
// }

/* -------------------------- Question12 -------------------------- */
// var num1 = +(window.prompt('Enter first number: '));
// var num2 = +(window.prompt('Enter second number: '));

// var val = 1;

// for(var i = 0; i < num2; i++) {
//   val *= num1;
// }

// console.log(val);

/* -------------------------- Question12 -------------------------- */
// var mark1 = +(window.prompt('Enter first mark: '));
// var mark2 = +(window.prompt('Enter second mark: '));
// var mark3 = +(window.prompt('Enter third mark: '));
// var mark4 = +(window.prompt('Enter fourth mark: '));
// var mark5 = +(window.prompt('Enter fifth mark: '));
// var sum = mark1 + mark2 + mark3 + mark4 + mark5;
// var average = sum / 5;
// var totalMarks = 500;
// var percentage = (sum / totalMarks) * 100;

// console.log('Total Marks: ', sum);
// console.log('Average Marks: ', average);
// console.log('Percentage:', percentage + '%');


/* -------------------------- Question13 -------------------------- */
// var month_number = Number(window.prompt('Enter month number: '));

// if(month_number == 1 || month_number == 3 || month_number == 5 ||
//    month_number == 7 || month_number == 8 || month_number == 10 ||
//    month_number == 12) {
//     console.log('Days in month: ', 31);
// }
// else if(month_number == 4 || month_number == 6 || month_number == 9 ||
//         month_number == 11) {
//           console.log('Days in month: ', 30);
// }
// else if(month_number == 2) {
//   console.log('Days in month: ', 28);
// }
// else {
//   console.log('Invalid Input.');
// }


/* -------------------------- Question14 -------------------------- */
// var physics     = +(window.prompt('Enter marks for Physics:'));
// var chemistry   = +(window.prompt('Enter marks for Chemistry:'));
// var biology     = +(window.prompt('Enter marks for Biology:'));
// var mathematics = +(window.prompt('Enter marks for Mathematics:'));
// var computer    = +(window.prompt('Enter marks for Computer:'));

// var totalMarks = 500; // Assuming each subject is out of 100
// var obtainedMarks = physics + chemistry + biology + mathematics + computer;
// var percentage = (obtainedMarks / totalMarks) * 100;

// var grade;
// if (percentage >= 90) {
//   grade = 'A';
// } else if (percentage >= 80) {
//   grade = 'B';
// } else if (percentage >= 70) {
//   grade = 'C';
// } else if (percentage >= 60) {
//   grade = 'D';
// } else if (percentage >= 40) {
//   grade = 'E';
// } else {
//   grade = 'F';
// }

// console.log('Total Marks: ' + obtainedMarks + '/' + totalMarks);
// console.log('Percentage: ' + percentage + '%');
// console.log('Grade: ' + grade);

/* -------------------------- Question15 -------------------------- */
// var month_number = Number(window.prompt('Enter month number:'));

// switch (month_number) {
//   case 1:
//   case 3:
//   case 5:
//   case 7:
//   case 8:
//   case 10:
//   case 12:
//     console.log('Days in month: 31');
//     break;

//   case 4:
//   case 6:
//   case 9:
//   case 11:
//     console.log('Days in month: 30');
//     break;

//   case 2:
//     console.log('Days in month: 28');
//     break;

//   default:
//     console.log('Invalid Input.');
// }

/* -------------------------- Question16 -------------------------- */
// var ch = window.prompt('Enter a character:');

// switch (ch) {
//   case 'a':
//   case 'A':
//   case 'e':
//   case 'E':
//   case 'i':
//   case 'I':
//   case 'o':
//   case 'O':
//   case 'u':
//   case 'U':
//     console.log('Vowel');
//     break;

//   default:
//     console.log('Consonant');
// }

/* -------------------------- Question17 -------------------------- */
// var num1 = +(window.prompt('Enter first number: '));
// var num2 = +(window.prompt('Enter second number: '));

// switch(true) {
//   case num1 >= num2:
//     console.log('max is: ', num1);
//   break;
//   case num2 > num1:
//     console.log('max is: ', num2);
//   break;
// }

/* -------------------------- Question18 -------------------------- */
// var num = +(window.prompt('Enter number: '));

// switch(true) {
//   case num % 2 == 0:
//     console.log('even');
//   break;
//   case num % 2 != 0:
//     console.log('odd');
//   break;
// }

/* -------------------------- Question19 -------------------------- */
// var num = +(window.prompt('Enter number: '));
// switch(true) {
//   case num > 0:
//     console.log('positive');
//   break;
//   case num < 0:
//     console.log('negativee');
//   break;
//   default:
//     console.log('zero');
// }

/* -------------------------- Question20 -------------------------- */
var num1 = +(window.prompt('Enter first number: '));
var num2 = +(window.prompt('Enter second number: '));
var ch = window.prompt("Enter operation (+, -, *, /, %, ^, **):");

switch (ch) {
  case '+':
    console.log(`${num1} + ${num2} = ${num1 + num2}`);
    break;

  case '-':
    console.log(`${num1} - ${num2} = ${num1 - num2}`);
    break;

  case '*':
    console.log(`${num1} * ${num2} = ${num1 * num2}`);
    break;

  case '/':
    if (num2 === 0) {
      console.log('Error: Division by zero is not allowed.');
    } else {
      console.log(`${num1} / ${num2} = ${num1 / num2}`);
    }
    break;

  case '%':
    if (num2 === 0) {
      console.log('Error: Modulo by zero is not allowed.');
    } else {
      console.log(`${num1} % ${num2} = ${num1 % num2}`);
    }
    break;

  case '**':
  case '^':
    console.log(`${num1} ^ ${num2} = ${num1 ** num2}`);
    break;

  default:
    console.log('Invalid Operation!');
}