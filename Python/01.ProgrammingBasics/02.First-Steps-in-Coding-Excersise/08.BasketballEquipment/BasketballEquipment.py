annual_membership_fee = int(input())

basketball_shoes_price = annual_membership_fee - 0.4 * annual_membership_fee
basketball_outfit_price = basketball_shoes_price - 0.2 * basketball_shoes_price
basketball_ball_price = basketball_outfit_price / 4
basketball_accessories_price = basketball_ball_price / 5

total_equipment_price = annual_membership_fee + basketball_shoes_price + basketball_outfit_price + basketball_ball_price + basketball_accessories_price

print(f'{total_equipment_price:.2f}')
