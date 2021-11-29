CREATE TABLE foo (a, b, c);
INSERT INTO foo VALUES (111, 222, 333), ('AAA', 'BBB', 'CCC');
EXPORT CSV '<TEMP>\file.csv' FROM TABLE foo OPTIONS (HEADER_ROW: 0);
PRINT '[' || READ_FILE_TEXT('<TEMP>\file.csv') || ']';

--output--
[111,222,333
AAA,BBB,CCC
]
