initial_points = float(input())

bonus_points = 0

if initial_points <= 100:
    bonus_points += 5
elif 100 < initial_points <= 1000:
    bonus_points += initial_points * 0.2
elif initial_points > 1000:
    bonus_points += initial_points * 0.1

if initial_points % 2 == 0:
    bonus_points += 1
elif initial_points % 10 == 5:
    bonus_points += 2

total_points = initial_points + bonus_points

print(bonus_points)
print(total_points)
