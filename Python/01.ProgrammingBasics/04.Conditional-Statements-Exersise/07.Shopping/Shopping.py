budget = float(input())
video_cards = int(input())
processors = int(input())
ram_memory = int(input())

video_cards_cost = video_cards * 250
processors_cost = processors * (video_cards_cost * 0.35)
ram_memory_cost = ram_memory * (video_cards_cost * 0.10)

total_cost = video_cards_cost + processors_cost + ram_memory_cost

if video_cards > processors:
    total_cost *= 0.85

budget_left = budget - total_cost

if budget_left >= 0:
    print(f"You have {budget_left:.2f} leva left!")
else:
    needed_money = abs(budget_left)
    print(f"Not enough money! You need {needed_money:.2f} leva more!")
