SELECT * FROM PRODUCTEF;
SELECT * FROM PRODUCTTYPEEF;

 INSERT INTO PRODUCTEF (PRODUCTNAME, FEATURES, AVERAGEPRICE, LOGOTIPO, ACTIVE, TYPEID  )
              VALUES ('Produto Tinta 1','Caracteristicas', 2000, 'http://www.logo.com.br/tinta1', 1, 1002);
 INSERT INTO PRODUCTEF (PRODUCTNAME, FEATURES, AVERAGEPRICE, LOGOTIPO, ACTIVE, TYPEID  )
              VALUES ('Produto Tinta 2','Caracteristicas', 1000, 'http://www.logo.com.br/tinta2', 0, 1003);
 INSERT INTO PRODUCTEF (PRODUCTNAME, FEATURES, AVERAGEPRICE, LOGOTIPO, ACTIVE, TYPEID  )
              VALUES ('Produto Agua 1','Caracteristicas', 10, 'http://www.logo.com.br/agua', 1, 1004);
 INSERT INTO PRODUCTEF (PRODUCTNAME, FEATURES, AVERAGEPRICE, LOGOTIPO, ACTIVE, TYPEID  )
              VALUES ('Produto Agua 2','Caracteristicas', 20, 'http://www.logo.com.br/agua2', 0, 1005);
COMMIT;