/*This program has been designed to run a math quiz game for elementary school children
to test their addition,
subtraction and multiplication and division facts.*/
#include&lt;iostream&gt; // new program
#include&lt;ctime&gt;
using namespace std;
// prototype
void addition();
void subtraction();
void multiplication();
void divide();
void addsub();
void muldiv();
void MathQuiz();
// calling game function
void MathQuiz() {
int choice1;
// asking the user to enter his choice of operation
// the problem number
cout &lt;&lt; &quot;-----MathQuiz-----&quot; &lt;&lt; endl;
cout &lt;&lt; &quot;You will be tested with 4 different math problems.&quot; &lt;&lt; endl;
cout &lt;&lt; &quot;Answer each problem the best that you can and then hit the ENTER button
on your keyboard.&quot; &lt;&lt; endl;
cout &lt;&lt; &quot;(1): Addition&quot; &lt;&lt; endl;
cout &lt;&lt; &quot;(2): Subtraction&quot; &lt;&lt; endl;
cout &lt;&lt; &quot;(3): Multplication&quot; &lt;&lt; endl;
cout &lt;&lt; &quot;(4): Devision&quot; &lt;&lt; endl;
cout &lt;&lt; &quot;(5): for mixed addition and subtraction&quot; &lt;&lt; endl;
cout &lt;&lt; &quot;(6):for mixed multiplication and division&quot; &lt;&lt; endl;
cout &lt;&lt; &quot;Enter your choice: &quot;;
cin &gt;&gt; choice1;

switch (choice1) {
case 1:
addition();
break;
case 2:
subtraction();
break;
case 3:
multiplication();
break;
case 4:
divide();
break;
case 5:
addsub();
break;
case 6:
muldiv();
break;
default: cout &lt;&lt; &quot;Enter a valid choice: &quot; &lt;&lt; endl;
}
}
// function definitions
//calling the addition function
void addition() {
int grade = 0; // grade initialization
for (int i = 0; i &lt; 10; i++) { // the loop for asking 10 questions
srand(time(0)); // Initialize num1 and num2 to two random numbers
int num1 = rand() % 100; // the addition should be 2 digits
int num2 = rand() % 100;
int answer;
cout &lt;&lt; &quot;How much is:&quot; &lt;&lt; endl;
cout &lt;&lt; &quot; &quot; &lt;&lt; num1 &lt;&lt; endl;
cout &lt;&lt; &quot;+ &quot; &lt;&lt; num2 &lt;&lt; endl;
cout &lt;&lt; &quot;-------&quot; &lt;&lt; endl;
cin &gt;&gt; answer;
if (num1 + num2 == answer) {
cout &lt;&lt; &quot;CORRECT, YOU KNOW YOUR STUFF&quot; &lt;&lt; endl;
grade++; // incrmenting the grade
}
else
cout &lt;&lt; &quot;SORRY BUT GOOD TRY. THE CORRECT ANSWER WAS: &quot; &lt;&lt; num1 +

num2 &lt;&lt; endl;
}
cout &lt;&lt; &quot;Your grade is &quot; &lt;&lt; grade &lt;&lt; &quot;/10&quot; &lt;&lt; endl;
if (grade &lt; 7) // telling the user to ask his teacher for extra help because of
his grade

cout &lt;&lt; &quot;Ask a teacher for extra help&quot; &lt;&lt; endl;

}
// calling the subtraction function
void subtraction() {
int grade = 0;
for (int i = 0; i &lt; 10; i++) {
srand(time(0));// Initialize num3 and num4 to two random numbers
int d = rand() % 50; // between 1 and 49
int num3 = rand() % 51; // between 1 and 50
int num4 = num3 + d; // greater number to obtain a positive subtraction
int answer;
cout &lt;&lt; &quot;How much is:&quot; &lt;&lt; endl;
cout &lt;&lt; &quot; &quot; &lt;&lt; num4 &lt;&lt; endl;
cout &lt;&lt; &quot;- &quot; &lt;&lt; num3 &lt;&lt; endl;
cout &lt;&lt; &quot;-------&quot; &lt;&lt; endl;
cin &gt;&gt; answer;
if (num4 - num3 == answer) {
cout &lt;&lt; &quot;THAT&#39;S IT, GREAT JOB!&quot; &lt;&lt; endl;
grade++;
}
else
cout &lt;&lt; &quot;GOOD TRY BUT THAT IS INCORRECT. THE CORRECT ANSWER WAS &quot; &lt;&lt;

num4 - num3 &lt;&lt; endl;
}
cout &lt;&lt; &quot;Your grade is &quot; &lt;&lt; grade &lt;&lt; &quot;/10&quot; &lt;&lt; endl;
if (grade &lt; 7)
cout &lt;&lt; &quot;Ask a teacher for extra help&quot; &lt;&lt; endl;

}

//calling the multiplication function
void multiplication() {
int grade = 0;
for (int i = 0; i &lt; 10; i++) {
srand(time(0));// Initialize num5 and num6 to two random numbers
int num5 = rand() % 100; // from 1 to 99 TWO DIIGIT NUMBER
int num6 = rand() % 10; // from 1 to 9 ONE DIGIT NUMBER
int answer;
cout &lt;&lt; &quot;How much is:&quot; &lt;&lt; endl;
cout &lt;&lt; &quot; &quot; &lt;&lt; num5 &lt;&lt; endl;
cout &lt;&lt; &quot;* &quot; &lt;&lt; num6 &lt;&lt; endl;
cout &lt;&lt; &quot;-------&quot; &lt;&lt; endl;

cin &gt;&gt; answer;
if (num5 * num6 == answer) {
cout &lt;&lt; &quot;THAT&#39;S IT, GREAT JOB!&quot; &lt;&lt; endl;
grade++;
}
else
cout &lt;&lt; &quot;THAT WAS A GREAT TRY. THE CORRECT ANSWER WAS &quot; &lt;&lt; num5 *

num6 &lt;&lt; endl;
}
cout &lt;&lt; &quot;Your grade is &quot; &lt;&lt; grade &lt;&lt; &quot;/10&quot; &lt;&lt; endl;
if (grade &lt; 7)
cout &lt;&lt; &quot;Ask a teacher for extra help&quot; &lt;&lt; endl;

}
// calling the division function
void divide() {
int grade = 0;
for (int i = 0; i &lt; 10; i++) {
srand(time(0));
int a1 = rand() % 11; // two digit number
int m = rand() % 10;
int a2 = m * a1; // whole quotient
int answer;
cout &lt;&lt; &quot; How much is &quot; &lt;&lt; a2 &lt;&lt; &quot; / &quot; &lt;&lt; a1 &lt;&lt; &quot; ? &quot;;
cin &gt;&gt; answer;
if (a2 / a1 == answer) {
cout &lt;&lt; &quot;THAT&#39;S IT, GREAT JOB!&quot; &lt;&lt; endl;
grade++;
}
else
cout &lt;&lt; &quot;GOOD TRY BUT THAT IS INCORRECT. THE CORRECT ANSWER WAS &quot; &lt;&lt;

a2 / a1 &lt;&lt; endl;
}
cout &lt;&lt; &quot;Your grade is &quot; &lt;&lt; grade &lt;&lt; &quot;/10&quot; &lt;&lt; endl;
if (grade &lt; 7)
cout &lt;&lt; &quot;Ask a teacher for extra help&quot; &lt;&lt; endl;

}
// calling the mixed opertions function addition and subtraction
void addsub() {
int grade = 0;
{
for (int i = 0; i &lt; 5; i++) {
srand(time(0));
int num1 = rand() % 100;
int num2 = rand() % 100;
int answer;
cout &lt;&lt; &quot;How much is:&quot; &lt;&lt; endl;
cout &lt;&lt; &quot; &quot; &lt;&lt; num1 &lt;&lt; endl;
cout &lt;&lt; &quot;+ &quot; &lt;&lt; num2 &lt;&lt; endl;
cout &lt;&lt; &quot;-------&quot; &lt;&lt; endl;

cin &gt;&gt; answer;
if (num1 + num2 == answer) {
cout &lt;&lt; &quot;CORRECT, YOU KNOW YOUR STUFF&quot; &lt;&lt; endl;
grade++;
}
else
cout &lt;&lt; &quot;Incorrect! The correct answer is: &quot; &lt;&lt; num1 + num2 &lt;&lt;

endl;

}
for (int i = 5; i &lt; 10; i++) {
srand(time(0));
int d = rand() % 100;
int num3 = rand() % 100;
int num4 = num3 + d;
int answer;
cout &lt;&lt; &quot;How much is:&quot; &lt;&lt; endl;
cout &lt;&lt; &quot; &quot; &lt;&lt; num4 &lt;&lt; endl;
cout &lt;&lt; &quot;- &quot; &lt;&lt; num3 &lt;&lt; endl;
cout &lt;&lt; &quot;-------&quot; &lt;&lt; endl;
cin &gt;&gt; answer;
if (num4 - num3 == answer) {
cout &lt;&lt; &quot;CORRECT, YOU KNOW YOUR STUFF&quot; &lt;&lt; endl;
grade++;
}
}
}
cout &lt;&lt; &quot;Your grade is &quot; &lt;&lt; grade &lt;&lt; &quot;/10&quot; &lt;&lt; endl;
if (grade &lt; 7)
cout &lt;&lt; &quot;Ask a teacher for extra help&quot; &lt;&lt; endl;

}
// calling the mixed operations function multiplication and division
void muldiv() {
int grade = 0;
{
for (int i = 0; i &lt; 5; i++) {
srand(time(0));
int num5 = rand() % 100;
int num6 = rand() % 10;
int answer;
cout &lt;&lt; &quot;How much is:&quot; &lt;&lt; endl;
cout &lt;&lt; &quot; &quot; &lt;&lt; num5 &lt;&lt; endl;
cout &lt;&lt; &quot;* &quot; &lt;&lt; num6 &lt;&lt; endl;
cout &lt;&lt; &quot;-------&quot; &lt;&lt; endl;
cin &gt;&gt; answer;
if (num5 * num6 == answer) {

cout &lt;&lt; &quot;THAT&#39;S IT, GREAT JOB!&quot; &lt;&lt; endl;
grade++;
}
else
cout &lt;&lt; &quot;Incorrect! The correct answer is: &quot; &lt;&lt; num5 * num6 &lt;&lt;

endl;

}
for (int i = 5; i &lt; 10; i++) {
srand(time(0));
int q1 = rand() % 11;
int m = rand() % 10;
int q2 = m * q1;
int answer;
cout &lt;&lt; &quot; How much is &quot; &lt;&lt; q2 &lt;&lt; &quot; / &quot; &lt;&lt; q1 &lt;&lt; &quot; ? &quot;;
cin &gt;&gt; answer;
if (q2 / q1 == answer) {
cout &lt;&lt; &quot;THAT&#39;S IT, GREAT JOB!&quot; &lt;&lt; endl;
grade++;
}
else
cout &lt;&lt; &quot;Incorrect! The correct answer is: &quot; &lt;&lt; q2 / q1 &lt;&lt;

endl;

}
}
cout &lt;&lt; &quot;Your grade is &quot; &lt;&lt; grade &lt;&lt; &quot;/10&quot; &lt;&lt; endl;
if (grade &lt; 7)
cout &lt;&lt; &quot;Ask a teacher for extra help&quot; &lt;&lt; endl;

}
// main function
int main() {
char choice; // choice of the user if he/she wants to do the quiz or not
do { // looping to keep the program running
cout &lt;&lt; &quot;Enter &#39;y&#39; for yes to play or &#39;n&#39; for no to stop: &quot;;
cin &gt;&gt; choice;
switch (choice) { // switch choice
case &#39;n&#39;:
// if the user press n the program will stop
break;
case &#39;y&#39;: // if the user press y then the program will run agin
cout &lt;&lt; &quot;New game will begin...&quot; &lt;&lt; endl;
MathQuiz(); // calling the game function
break;
default:cout &lt;&lt; &quot;Enter a valid choice please:&quot; &lt;&lt; endl;//if the user did
not enter the valid choice the program will ask him/her to enter the valid choice

break;
}

} while (choice != &#39;n&#39;); // for thr program to keep looping keep looping

system(&quot;pause&quot;);
return 0;
}