import json
import oracledb

with open('config.json', 'r') as json_file:
    json_data = json.load(json_file)

connection = oracledb.connect(
    user=json_data['username'],
    password=json_data['password'],
    dsn=f"localhost/{json_data['pdb_name']}")

print("Successfully connected to Oracle Database")

