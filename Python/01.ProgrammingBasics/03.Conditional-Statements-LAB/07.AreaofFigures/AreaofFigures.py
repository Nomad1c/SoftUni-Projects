import math

figure_type = input()

if figure_type == "square":
    side_length = float(input())
    area = side_length ** 2
elif figure_type == "rectangle":
    width = float(input())
    height = float(input())
    area = width * height
elif figure_type == "circle":
    radius = float(input())
    area = math.pi * radius ** 2
elif figure_type == "triangle":
    side_length = float(input())
    height = float(input())
    area = (side_length * height) / 2

print(f"{area:.3f}")
