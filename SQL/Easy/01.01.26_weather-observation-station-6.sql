SET NOCOUNT ON;

/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

-- Problem: weather-observation-station-6
-- Difficulty: Easy
-- Platform: HackerRank
-- Link: https://www.hackerrank.com/challenges/weather-observation-station-6

SELECT DISTINCT CITY
FROM STATION s
WHERE SUBSTRING(s.City, 1, 1) IN ('a','e','i','o','u');

go