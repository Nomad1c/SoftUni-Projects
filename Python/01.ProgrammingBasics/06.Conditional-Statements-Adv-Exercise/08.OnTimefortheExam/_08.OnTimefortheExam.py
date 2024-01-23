exam_hour = int(input())
exam_minute = int(input())
arrival_hour = int(input())
arrival_minute = int(input())

exam_time_in_minutes = exam_hour * 60 + exam_minute
arrival_time_in_minutes = arrival_hour * 60 + arrival_minute

difference = arrival_time_in_minutes - exam_time_in_minutes

if difference < -30:
    print("Early")
    if difference <= -60:
        hours = abs(difference) // 60
        minutes = abs(difference) % 60
        print(f"{hours}:{minutes:02d} hours before the start")
    else:
        print(f"{abs(difference)} minutes before the start")

elif -30 <= difference <= 0:
    print("On time")
    if difference != 0:
        print(f"{abs(difference)} minutes before the start")

else:
    print("Late")
    if difference >= 60:
        hours = abs(difference) // 60
        minutes = abs(difference) % 60
        print(f"{hours}:{minutes:02d} hours after the start")
    else:
        print(f"{abs(difference)} minutes after the start")
