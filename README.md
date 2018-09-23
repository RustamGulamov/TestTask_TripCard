Вы собираетесь совершить долгое путешествие через множество населенных пунктов.
Чтобы не запутаться, вы сделали карточки вашего путешествия. Каждая карточка содержит в себе пункт отправления и пункт назначения.
Гарантируется, что если упорядочить эти карточки так, чтобы для каждой карточки в упорядоченном списке пункт назначения на ней совпадал с пунктом отправления в следующей карточке в списке, получится один список карточек без циклов и пропусков.

Например, у нас есть карточки
Мельбурн → Кельн
Москва → Париж
Кельн → Москва

Если упорядочить их в соответствии с требованиями выше, то получится следующий список:
Мельбурн → Кельн, Кельн → Москва, Москва → Париж

Требуется:
1. Написать функцию, которая принимает набор неупорядоченных карточек и возвращает набор упорядоченных карточек в соответствии с требованиями выше, то есть в возвращаемом из функции списке карточек для каждой карточки пункт назначения на ней должен совпадать с пунктом отправления на следующей карточке.
2. Написать тесты.
