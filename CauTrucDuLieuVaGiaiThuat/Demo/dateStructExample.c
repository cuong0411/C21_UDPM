// Program to determine tomorrow's date

#include<stdio.h>
#include<stdbool.h>

struct date
{
    int day;
    int month;
    int year;
};

//the prototype declaration
int numberOfDays(struct date d);
bool isLeapYear(struct date d);
struct date dateUpdate(struct date today);

int main()
{
    struct date dateUpdate(struct date today);
    struct date thisDay, nextDay;

    printf("Enter the today's date (dd mm yyyy): ");
    scanf("%i%i%i", &thisDay.day, &thisDay.month, &thisDay.year);

    nextDay = dateUpdate(thisDay);

    // using compound literals
    //nextDay = dateUpdate((struct date) {28, 2, 2000});

    printf("Tomorrow's date is %i/%i/%.2i\n", nextDay.day, nextDay.month, nextDay.year);

    return 0;
}

// Function to calculate tomorrow's date
struct date dateUpdate(struct date today)
{
    struct date tomorrow;

    if (today.day != numberOfDays(today)) {

        //#1
        // tomorrow.day = today.day + 1;
        // tomorrow.month = today.month;
        // tomorrow.year = today.year;

        //#2 using compound literals
        tomorrow = (struct date) {today.day + 1, today.month, today.year};
    }
    else if (today.month == 12) {
        tomorrow.day = 1;
        tomorrow.month = 1;
        tomorrow.year = today.year + 1;
    }
    else {
        tomorrow.day = 1;
        tomorrow.month = today.month + 1;
        tomorrow.year = today.year;
    }
    return tomorrow;
}
// Function to find the number of days in a month
int numberOfDays(struct date d)
{
    int days;
    bool isLeapYear(struct date d);
    const int dayPerMonth[] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

    if(isLeapYear(d) == true && d.month == 2)
        days = 29;
    else
        days = dayPerMonth[d.month - 1];
    return days;
}
// Function to determine if it's a leap year
bool isLeapYear(struct date d)
{
    bool leapYearFlag;
    if((d.year % 4 == 0 && d.year % 100 != 0) || d.year % 400 ==0)
        leapYearFlag = true;
    else
        leapYearFlag = false;
    return leapYearFlag;
}
