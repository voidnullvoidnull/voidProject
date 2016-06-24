#voidProject

#NodeEventHelper
<Статический класс-помощник по обработке событий, приходящих с рабочего поля Canvas, а также для связи этих событий с методами, реализующими функционал NodeManager. Также реализует функцию по отрисовке соединительных кривых Безье, а точнее, предоставляет объект геометрии, который будет использоват вызывающим методом на своё усмотрение.>

#NodeBase
Базовый абстрактный класс для элементов, которые могут взаимодействовать в рамках методов NodeManager. Реализует хранение ссылок на текущий Canvas отображения и NodeManager, в котором производятся операции над объектом, реализующий данный класс

#NodeContent
Базовый класс для всех элементов управления и содержимого нодов. Все элементы управления и контент помещаются в контейнер panel : StackPanel, где автоматически выравнивается. Однако, никто не запрещает реализовывать свои контейнеры. Переопределяя метод GetInfo нужно в переопределямом методе сохранять значения из базовой реалзации, так как они содержат в себе координаты, тип и уникальный ID. Соотвественно, конструктор реализующего класса также должен вызывать базовый перед вызовом своего.
 
#NodeModelInfo
Представляет из себя структуру данных, проецирующую на себя информацию из NodeManager, для последующего их сохранения на диск.Содержит методы добавления информации по элеметам и ссылкам в формате, удобном для сохранения.
 
#NodeInfo
Структура единицы хранения данных о конктерном ноде.Сохраняется уникальный идентификатор, тип содержимого, который будет восстанавливаться при десериализации, координаты и массив props, который служит для хранения информации уникальной для каждого созданного contentType. Props будут обрабатываться отдельно в зависимости от контекста и типа содержимого.

#Node
Базовый класс - единица хранения данных о ноде.	Содержит в себе ссылки, унаследованные от базового класса на менеджер и canvas,в котором должен быть размещен отображаемый элемент упарвления, который значится под ссылкой - control.	В свою очередь, видимый эелемент управления должен содержать в себе уникальный для типа нодов набор элементов управления, на которые указывает ссылка - content - на объект, реализующий абстрактный класс NodeContent.


#NodeLink
Класс реализующий и хранящий в себе данные о соединенных нодах. Также, хранит ссылку на визуальное представление соединения в виде кривой Безье, которая помещается в Canvas рабочего поля.

#NodeManager
Класс-менеджер, которые осуществлят обработку всех операции, проводимых с нодами, ссылками, восстановлением и сохранением данных. Содержит в себе общее количество когда-либо созданных элементов в рамках загруженного файла исходя из которого присваивает уникальные номера элементам. Содержит методы, реализующие основные операции с элементами нодов. А также массивы ссылок на элементы и их соединения.

