namespace Functions
{
    public class ClassRoom
    {
        private List<Student> students = new List<Student>();
        /// <summary>
        /// Tüm öğrencileri bellekten siler.
        /// </summary>
        public void Clear() => students.Clear();
        /// <summary>
        /// id'sini vererek bir öğrenciyi bulabilirsiniz.
        /// </summary>
        /// <param name="id">öğrenci id'si</param>
        /// <returns>Student döner</returns>
        public Student FindLinq(int id) => students.Find(student => student.Id == id);
        public Student Find(int id)
        {
            foreach (var item in students)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void Add(Student student)
        {
            students.Add(student);
        }


        bool isIdEqual(Student student, int id)
        {
            return student.Id == id;
        }

    }
}
