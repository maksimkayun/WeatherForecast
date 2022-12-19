-- CREATE USER admin WITH PASSWORD 'admin1234';

-- CREATE TABLE IF NOT EXISTS weather_forecasts
-- (
--     id integer NOT NULL,
--     date timestamp with time zone,
--     temperature_c integer NOT NULL,
--     summary character varying COLLATE pg_catalog."default" NOT NULL
-- );
-- 
-- insert into weather_forecasts values 
-- (1,'2022-06-23 03:25:00',15, 'test1'),
-- (2,'2022-06-23 03:25:00',16, 'test2'),
-- (3,'2022-06-23 03:25:00',17, 'test3');

CREATE TABLE IF NOT EXISTS `weather_forecasts` (    
    `id` integer NOT NULL PRIMARY KEY,    
    `datetime` date DEFAULT NULL,    
    `temperature_c` integer DEFAULT NULL,
    `summary` varchar(256) DEFAULT NULL,
     PRIMARY KEY (`id`)
    ) ENGINE=InnoDB DEFAULT CHARSET=utf8;