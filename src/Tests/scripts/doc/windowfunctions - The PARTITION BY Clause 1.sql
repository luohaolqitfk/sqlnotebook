-- https://sqlite.org/windowfunctions.html
CREATE TABLE t1(a INTEGER PRIMARY KEY, b, c);
INSERT INTO t1 VALUES   (1, 'A', 'one'  ),
                        (2, 'B', 'two'  ),
                        (3, 'C', 'three'),
                        (4, 'D', 'one'  ),
                        (5, 'E', 'two'  ),
                        (6, 'F', 'three'),
                        (7, 'G', 'one'  );

-- The following SELECT statement returns:
-- 
--   c     | a | b | group_concat
---------------------------------
--   one   | 1 | A | A.D.G       
--   one   | 4 | D | D.G         
--   one   | 7 | G | G           
--   three | 3 | C | C.F         
--   three | 6 | F | F           
--   two   | 2 | B | B.E         
--   two   | 5 | E | E           
-- 
SELECT c, a, b, group_concat(b, '.') OVER (
  PARTITION BY c ORDER BY a RANGE BETWEEN CURRENT ROW AND UNBOUNDED FOLLOWING
) AS group_concat
FROM t1 ORDER BY c, a;

--output--
c,a,b,group_concat
one,1,A,A.D.G
one,4,D,D.G
one,7,G,G
three,3,C,C.F
three,6,F,F
two,2,B,B.E
two,5,E,E
-
