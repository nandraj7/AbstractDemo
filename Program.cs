

using AbstractDemo;

Teacher teacher = new Teacher();
teacher.Display();

Student student = new Student();
student.Display();

Employee employee = new Employee();
employee.Display();

Doctor doctor = new Doctor();
doctor.Display();


Person person;

person = teacher;
person.Display();       //Teacher Display();

person = student;
person.Display();       //Student Display();

person = employee;
person.Display();       //Employee Display();

person = doctor;
person.Display();       //Doctor Display();



person = teacher;
doctor.DemoOfReferenceCall(person);       //Teacher Display();

person = student;
doctor.DemoOfReferenceCall(person);       //Student Display();

person = employee;
doctor.DemoOfReferenceCall(person);       //Employee Display();

person = doctor;
doctor.(person);       //Doctor Display();