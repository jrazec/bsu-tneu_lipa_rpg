--PREDEFINED TABLES--
CREATE TABLE IF NOT EXISTS characters(
    charac_id INT PRIMARY KEY,
    charac_name VARCHAR(30),
    charac_type VARCHAR(20),
    charac_desc TEXT
);

CREATE TABLE IF NOT EXISTS students(
    sr_code VARCHAR(8) PRIMARY KEY,
    password VARCHAR(30) NOT NULL,
    in_game_name VARCHAR(20),
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    gender VARCHAR(20),
    current_money NUMERIC(7,2),
    charac_id INT REFERENCES characters(charac_id)
);

CREATE TABLE IF NOT EXISTS items(
    item_id INT PRIMARY KEY,
    item_name VARCHAR(40),
    item_price NUMERIC(6,2),
    item_class VARCHAR(20),
    item_desc TEXT
);

CREATE TABLE IF NOT EXISTS student_items (
    student_item_id SERIAL PRIMARY KEY,
    is_owned BOOLEAN,
    sr_code VARCHAR(8) REFERENCES students(sr_code),
    item_id INT REFERENCES items(item_id)
);

CREATE TABLE IF NOT EXISTS day_tasks(
    day_task_id INT PRIMARY KEY,
    day_name VARCHAR(10),
    day_garment_type VARCHAR(30),
    day_task_hint TEXT,
    day_task_clue TEXT
);

CREATE TABLE IF NOT EXISTS achievements(
    achievement_id INT PRIMARY KEY,
    ach_name VARCHAR(50),
    ach_desc TEXT
);

CREATE TABLE IF NOT EXISTS tasks(
    task_id INT PRIMARY KEY,
    task_name VARCHAR(50),
    reward NUMERIC(6,2),
    day_task_id INT REFERENCES day_tasks(day_task_id),
    achievement_id INT REFERENCES achievements(achievement_id)
);

CREATE TABLE IF NOT EXISTS gameplay_records (
    gameplay_id SERIAL PRIMARY KEY,
    date_finished DATE,
    status BOOLEAN,
    sr_code VARCHAR(8) REFERENCES students(sr_code),
    task_id INT REFERENCES tasks(task_id)
);