import math

series_name = input()
episode_duration = int(input())
break_duration = int(input())

lunch_time = break_duration * 1/8
relax_time = break_duration * 1/4
remaining_time = break_duration - lunch_time - relax_time

episodes_possible = remaining_time // episode_duration

if episodes_possible >= 1:
    remaining_time = math.ceil(remaining_time - (episodes_possible - 1) * episode_duration)
else:
    needed_time = math.ceil(episode_duration - remaining_time)
    remaining_time = math.ceil(needed_time)

print(f"You have enough time to watch {series_name} and left with {remaining_time} minutes free time.")
