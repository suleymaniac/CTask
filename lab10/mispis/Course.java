import java.util.*;

public class Course {

	public Course(Collection<Lecturer> teaches, String name, int id, float hours) {
		this.teaches = teaches;
		this.name = name;
		this.id = id;
		this.hours = hours;
	}

	Collection<Lecturer> teaches;
	public String name;
	public int id;
	public float hours;

	public void assignStudentToCourse(){

	}
	public void unsubscribeStudentFromCourse(){

	}
	public void giveStudentGradeForCourse(){

	}

}