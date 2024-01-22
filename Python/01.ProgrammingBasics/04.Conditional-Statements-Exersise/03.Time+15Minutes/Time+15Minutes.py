hours = int(input())
minutes = int(input())

total_minutes = hours * 60 + minutes + 15
new_hours = total_minutes // 60
new_minutes = total_minutes % 60

print(f"{new_hours % 24:2d}:{new_minutes:02d}")
