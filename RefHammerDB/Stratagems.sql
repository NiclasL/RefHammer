-- Load the CSV data into the temporary table
COPY temp_csv_data FROM '/path/to/csv/file.csv' DELIMITER ',' CSV HEADER;

-- Insert the data from the temporary table into the target table
INSERT INTO target_table (column1, column2, ...)
SELECT column1, column2, ...
FROM temp_csv_data;