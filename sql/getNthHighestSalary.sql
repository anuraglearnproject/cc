CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN   
RETURN
( 
        /* Write your T-SQL query statement below. */
        SELECT Salary
        FROM (
            SELECT DISTINCT Salary, DENSE_RANK() OVER (ORDER BY Salary DESC) AS RowNum FROM Employee
        )
    AS RankedSalary 
    WHERE RowNum = @N
)
END