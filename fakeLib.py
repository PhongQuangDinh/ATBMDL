from faker import Faker
import random
import string
from hashlib import sha256
from datetime import datetime, timedelta

fake = Faker()

#-------------config stuff below----------------------

branch_size = 5
Branch_list = []

student_size = 1000
student_list = []

takenTRGDV = set()
DONVI_name = ["N'Văn phòng khoa'",
              "N'Bộ môn HTTT'",
              "N'Bộ môn CNPM'",
              "N'Bộ môn KHMT'",
              "N'Bộ môn CNTT'",
              "N'Bộ môn TGMT'",
              "N'Bộ môn MMT và Viễn thông'"]
DONVI_TRG = []

EmployeeSize = 107
roleList = ["N'Nhân viên cơ bản'",
            "N'Giảng viên'",
            "N'Giáo vụ'",
            "N'Trưởng đơn vị'",
            "N'Trưởng khoa'"]

EmployeeDict = {
  "N'Nhân viên cơ bản'": [0,10,[]],
  "N'Giảng viên'": [0,80,[]],
  "N'Giáo vụ'": [0,10,[]],
  "N'Trưởng đơn vị'": [0,6,[]],
  "N'Trưởng khoa'": [0,1,[]]
}

HocPhanSize = 50
HocPhanList = {"N'Nhập môn công nghệ phần mềm'":[4,[]],
               "N'Nhập môn lập trình'":[4,[]],
               "N'Blockchain và ứng dụng'":[4,[]],
               "N'Hệ thống viễn thông'":[4,[]],
               "N'Thương mại điện tử'":[4,[]],
               "N'Tương tác người máy'":[4,[]],
               "N'Lập trình song song ứng dụng'":[4,[]],
               "N'Kiến trúc phần mềm'":[4,[]],
               "N'Kiểm thử phần mềm'":[4,[]],
               "N'An ninh máy tính'":[4,[]],
               "N'Thiết kế giao diện'":[4,[]],
               "N'Học thống kê'":[4,[]],
               "N'Automata và ngôn ngữ hình thức'":[4,[]],
               "N'Truy vấn thông tin thị giác'":[4,[]],
               "N'Nhập môn dữ liệu lớn'":[4,[]],
               "N'Khai thác dữ liệu đồ thị'":[4,[]],
               "N'Cơ sở dữ liệu'":[4,[]],
               "N'Cơ sở dữ liệu nâng cao'":[4,[]],
               "N'Vật lý cho công nghệ thông tin'":[4,[]],
               "N'Hệ thống máy tính'":[4,[]],
               "N'Hệ điều hành'":[4,[]],
               "N'Mạng máy tính'":[4,[]],
               "N'Kỹ thuật lập trình'":[4,[]],
               "N'Cấu trúc dữ liệu và giải thuật'":[4,[]],
               "N'Đại số tuyến tính'":[4,[]],
               "N'Cơ sở trí tuệ nhân tạo'":[4,[]],
               "N'Quản lý dự án phần mềm'":[4,[]],
               "N'Nhập môn thiết kế và phân tích giải thuật'":[4,[]],
               "N'Thực tập thực tế'":[4,[]],
               "N'Chuyên đề xử lý ảnh số và video số'":[4,[]],
               "N'Hệ thống tư vấn'":[4,[]],
               "N'Ứng dụng phân tán'":[4,[]],
               "N'Khởi nghiệp'":[3,[]],
               "N'Vật lý đại cương 1'":[4,[]],
               "N'Xác suất thống kê'":[4,[]],
               "N'Pháp luật đại cương'":[3,[]],
               "N'Thể dục 1'":[2,[]],
               "N'Thể dục 2'":[2,[]],
               "N'Nhập môn học máy'":[4,[]],
               "N'Mã hóa ứng dụng'":[4,[]],
               "N'Bảo mật cơ sở dữ liệu'":[4,[]],
               "N'An toàn và bảo mật dữ liệu trong hệ thống thông tin'":[4,[]],
               "N'Phân tích thiết kế hệ thống thông tin'":[4,[]],
               "N'Trực quan hóa dữ liệu'":[4,[]],
               "N'Phát triển phần mềm cho thiết bị di động'":[4,[]],
               "N'Phân tích và quản lý yêu cầu phần mềm'":[4,[]],
               "N'Lập trình Windows'":[4,[]],
               "N'Thiết kế phần mềm'":[4,[]],
               "N'Nhận dạng'":[4,[]],
               "N'Phương pháp nghiên cứu khoa học'":[4,[]]}

KHMOsize = 200
KHMOlist = set()

PHANCONGsize = 1000
PHANCONGlist = set()

DANGKYsize = 5000
DANGKYlist = set()


takenPhone = set()

#--------------------config stuff above------------------------


def gen_ROLE(id: int) -> str: # havent used this
    role = random.choice(roleList)
    while EmployeeDict[role][0] >= EmployeeDict[role][1]:
        role = random.choice(roleList)
    EmployeeDict[role][0] += 1
    EmployeeDict[role][2].append(id)
    if role == "N'Trưởng đơn vị'": DONVI_TRG.append(id)
    return role

def gen_MACT() -> str:
    stuff = ["'CQ'",
             "'CLC'",
             "'CTTT'",
             "'VP'"
             ]
    return random.choice(stuff)

def gen_MANGANH() -> str:
    stuff = ["'MMT'",
             "'HTTT'",
             "'KTPM'",
             "'KHMT'",
             "'CNTThuc'",
             "'TGMT'",
             "'KHDL'",
             "'CNTTin'"
             ]
    return random.choice(stuff)

def gen_price(min, max) -> str:
    res = fake.pyfloat(min_value=min, max_value=max, right_digits=2)
    num_str = str(int(res))
    num_digits = len(num_str)
    round_digits = num_digits - 3 if num_digits - 3 >= 0 else num_digits - 2 if num_digits - 2 >= 0 else num_digits - 1
    return round(res, -round_digits)

def gen_roomName() -> str:
    return random.choice(["N'Phòng nhổ răng'","N'Phòng trám răng'", "N'Phòng trồng răng'"])

def hashPass(password: str) -> str:
    return sha256(password.encode('utf-8')).hexdigest()

def gen_address(max_length: int) -> str:
    res = ''
    while (res == '' or len(res) > max_length):
        siu = fake.address().split('\n')
        res = siu[0] + ', ' + siu[1].split(',')[0]
    return f"'{res}'"

def gen_name(max_length: int) -> str:
    res = ''
    while (res == '' or len(res) > max_length):
        res = fake.name()
    return f"'{res}'"

def gen_phone() -> str:
    res = '0' + ''.join(random.choices(string.digits, k=9))
    while res in takenPhone:
        res = '0' + ''.join(random.choices(string.digits, k=9))
    takenPhone.add(res)
    return f"'{res}'"

def gen_gender() -> str:
    return "N'Nam'" if random.randint(0,1) == 0 else "N'Nữ'"

def gen_birthday(min_age, max_age) -> str:
    res = fake.date_of_birth(None,min_age, max_age)
    return f"'{res}'"

def gen_date(min, max): # hmmmmmmmm
    return fake.date()

def gen_nationalID() -> str:
    return '0' + ''.join(random.choices(string.digits, k=11))

def gen_sentence(max_length: int) -> str:
    res = ''
    while (res == '' or len(res) > max_length):
        res = fake.sentence()
    return res

def gen_datetime(min, max) -> str:
    res = ''
    while (res == '' or datetime.now().year - res.year < min or datetime.now().year - res.year > max):
        res = fake.date_time()
    return str(res)

def gen_time(min, max) -> str:
    res = ''
    while (res == '' or int(res[0:2]) < min or int(res[0:2]) > max):
        res = fake.time()
    return res

# for _ in range(100):
#     print(fake.future_datetime())


# -------------------------------------------------
# import random

# my_list = ["apple", "banana", "cherry", "orange"]
# random_element = random.choice(my_list)

# print(f"Random element: {random_element}")
# print(fake.time())