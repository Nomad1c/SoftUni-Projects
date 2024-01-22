time_runner1 = int(input())
time_runner2 = int(input())
time_runner3 = int(input())

total_time_seconds = time_runner1 + time_runner2 + time_runner3

minutes = total_time_seconds // 60
seconds = total_time_seconds % 60

print(f"{minutes}:{seconds:02}")
