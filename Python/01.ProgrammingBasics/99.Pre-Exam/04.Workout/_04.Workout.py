import math

days = int(input())
initial_distance = float(input())
total_distance = initial_distance

for _ in range(days):
    increase_percentage = int(input())
    initial_distance += (increase_percentage / 100.0) * initial_distance
    total_distance += initial_distance

extra_distance = math.ceil(abs(total_distance - 1000))

if total_distance >= 1000:
    print(f"You've done a great job running {int(extra_distance)} more kilometers!")
else:
    print(f"Sorry Mrs. Ivanova, you need to run {int(extra_distance)} more kilometers")
