using System;

// STEP 1: Read the below code - we have created a variable called localDate (which is data type DateTime) - this stores the current date and time for your computer
DateTime localDate = DateTime.Now;


// STEP 2a: Have a look at the below code - we have created two variables (of data type string) that contain the hour (2:00pm would be 14), and the day of the week (Tuesday for example)
string day = localDate.ToString("dddd");
string hourString = localDate.ToString("HH");


// STEP 2b: Examine the below line of code - we need to convert the variable hour to an integer (so we can use relational operators later)
int hour = Int32.Parse(hourString);


// STEP 3: Create an 'if' condition to check whether it is the weekend
if (day == "Saturday" || day == "Sunday")
{
    // STEP 5a: It is either Saturday or Sunday, so now we need an if/else condition to see whether it is time to wake up or not
    if (hour >= 9)
    {
        // STEP 5b: It is 9am or later
        Console.WriteLine("It is the weekend and it is time to get up and enjoy the day.");
    }
    else
    {
        // STEP 5c: It is not yet 9am
        Console.WriteLine("It is not yet time to get out of bed.");
    }
}
else
{
    // STEP 6a: We need to create a condition that checks to see whether it is 6am or later
    if (hour >= 6)
    {
        // STEP 6b: It is indeed 6am or later
        Console.WriteLine("It is time to wake up and get ready for the work day.");
    }
    else
    {
        // STEP 6c: It is not yet 6am
        Console.WriteLine("It is not yet time to get out of bed.");
    }
}



