length_cm = int(input())
width_cm = int(input())
height_cm = int(input())
percentage_occupied = float(input())

volume_cm3 = length_cm * width_cm * height_cm
volume_liters = volume_cm3 * 0.001
occupied_space = percentage_occupied / 100
needed_liters = volume_liters * (1 - occupied_space)

print(f'{needed_liters:.5f}')
