class Singleton {
  // Поле для хранения объекта-одиночки
  static final Singleton _singleton = new Singleton._internal();

  String scheme;
  String host;
  String endpoint;

  // Конструктор класса с именованными параметрами,
  // который, на самом деле, возвращает существующий экземпляр одиночки
  factory Singleton({String scheme = 'https', String host = '127.0.0.1', String endpoint = ''}) {
    _singleton.scheme = scheme;
    _singleton.host = host;
    _singleton.endpoint = endpoint;
    return _singleton;
  }

  // Приватный метод, создающий объект одиночки
  Singleton._internal({String scheme, String host, String endpoint}) {
    this.scheme = scheme;
    this.host = host;
    this.endpoint = endpoint;
  }

  String getUrl() {
    return '${scheme}://${host}/${endpoint}';
  }
}

void main() {
  // Создаем экземпляр одиночки
  Singleton s1 = new Singleton(host: 'mail.ru');
  print(s1.getUrl());  // https://mail.ru/

  // Создаем ещё один экземпляр одиночки
  Singleton s2 = new Singleton(host: 'yandex.ru', endpoint: 'profi/');
  // Видим, что на самом деле это один и тот же объект
  print(s2.getUrl());  // https://yandex.ru/profi/
  print(s1.getUrl());  // https://yandex.ru/profi/
}
