namespace Day6_lab.Models
{
    public class Student
    {
        public int Id { get; set; } //Mã sinh viên
        public string ? Name { get; set; } //Tên sinh viên
        public string ? Email { get; set; } //Email sinh viên
        public string ? Password { get; set; } //mật khẩu 
        public Branch? Branch { get; set; } //Ngành học
        public Gender? Gender { get; set; } // Giới tính
        public bool IsRegular { get; set; } ////Hệ: true-chính qui, false-phi cq
        public string ? Address { get; set; } //Địa chỉ
        public DateTime Date0fBorth { get; set; } //Ngày sinh



    }
}
