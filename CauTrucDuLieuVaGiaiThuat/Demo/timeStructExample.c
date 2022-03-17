#include<stdio.h>

struct time
{
    int hour;
    int minute;
    int second;
};

struct time timeUpdate(struct time now);
int main()
{
    struct time currentTime, nextTime;
    printf("Enter the time(hh:mm:ss): ");
    scanf("%i%i%i", &currentTime.hour, &currentTime.minute, &currentTime.second);

    nextTime = timeUpdate(currentTime);
    printf("Updated time is %.2i:%.2i:%.2i", nextTime.hour, nextTime.minute, nextTime.second);
    
    return 0;
}

struct time timeUpdate(struct time now)
{
    now.second++;
    if(now.second == 60) {
        now.second = 0;
        now.minute++;
        if(now.minute == 60) {
            now.minute = 0;
            now.hour++;
            if(now.hour == 24) {
                now.hour = 0;
            }
        }
    }
    return now;
}