using System;

// STEP 1: Read the below code - we have created a variable called localDate (which is data type DateTime) - this stores the current date and time for your computer
DateTime localDate = DateTime.Now;


// STEP 2a: Have a look at the below code - we have created two variables (of data type string) that contain the hour (2:00pm would be 14), and the day of the week (Tuesday for example)
string day = localDate.ToString("dddd");
string hourString = localDate.ToString("HH");



