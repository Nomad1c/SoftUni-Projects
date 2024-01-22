import math

record_seconds = float(input())
distance_meters = float(input())
time_per_meter_seconds = float(input())

water_resistance_seconds = (distance_meters // 15) * 12.5
ivan_time = distance_meters * time_per_meter_seconds + water_resistance_seconds

if ivan_time < record_seconds:
    print(f"Yes, he succeeded! The new world record is {ivan_time:.2f} seconds.")
else:
    time_difference = ivan_time - record_seconds
    print(f"No, he failed! He was {time_difference:.2f} seconds slower.")
