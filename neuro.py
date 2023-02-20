import cv2
import numpy as np
import os

# Определяем путь к папкам с изображениями
image_folder_path = 'C:/Users/KOSHARIK/Desktop'

# Определяем путь к изображению, которое нужно найти
query_image_path = 'C:/Users/KOSHARIK/Desktop/checkphoto.png'

# Определяем пороговое значение для сравнения
threshold = 0.75

# Загружаем изображение, которое нужно найти
query_image = cv2.imread(query_image_path, 0)

# Инициализируем ORB детектор и дескриптор
orb = cv2.ORB_create()

# Извлекаем ключевые точки и дескрипторы для изображения, которое нужно найти
query_keypoints, query_descriptors = orb.detectAndCompute(query_image, None)

# Создаем пустой список для хранения найденных изображений
found_images = []

# Проходим по всем папкам с изображениями
for foldername in os.listdir(image_folder_path):
    folderpath = os.path.join(image_folder_path, foldername)
    if os.path.isdir(folderpath):
        # Проходим по всем файлам с изображениями в папке
        for filename in os.listdir(folderpath):
            filepath = os.path.join(folderpath, filename)
            # Загружаем изображение
            image = cv2.imread(filepath, 0)
            # Извлекаем ключевые точки и дескрипторы для изображения
            keypoints, descriptors = orb.detectAndCompute(image, None)
            # Сравниваем дескрипторы двух изображений с помощью метода BFMatcher
            matcher = cv2.BFMatcher(cv2.NORM_HAMMING, crossCheck=True)
            matches = matcher.match(query_descriptors, descriptors)
            # Оцениваем сходство двух изображений на основе количества найденных соответствий
            similarity = len(matches) / len(query_descriptors)
            # Если сходство больше порогового значения, то добавляем изображение в список найденных изображений
            if similarity > threshold:
                found_images.append(filepath)

# Выводим список найденных изображений
print(found_images)
