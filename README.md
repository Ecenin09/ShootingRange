# ShootingRange
Physics/Генерация

Тир с генерацией мишеней/снарядов. Управление с помощью экранного джойстика и кнопки.

Игрок стоит в сцене, не может двигаться, но может поворачиваться из стороны в сторону и смотреть вверх/вниз, 
при нажатии на кнопку генерируется снаряд(физический объект) который вылетает из центра камеры в направлении взгляда.

1. Каждая мишень - набор физических объектов(шар, куб) собранных в геометрическую фигуру(пирамида, куб). 
Всего 4-е типа мишеней. Мишень должна сохранять форму до попадания снаряда. При попадании снаряда должна реагировать по физике.

2. Мишени генерируются вокруг игрока на заданном отдалении.

3. Снаряд - физических объект(шар, куб. Выбирается случайно при выстреле). 
При попадании в мишень взрывается с заданным радиусом. Объекты внутри радиуса уничтожаются, а за пределами радиуса получают импульс.
