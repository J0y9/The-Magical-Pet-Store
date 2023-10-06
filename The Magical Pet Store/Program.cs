using The_Magical_Pet_Store;

var pet1 = new MagicalPet("Dragon","Breathing Fire");
var pet2 = new MagicalPet("Magical Rabbit","Super Jumping");
pet1.DisplayInfo();
pet2.DisplayInfo();
var student1 = new Student("Ali");
student1.FeedPet(pet1);
student1.ExercisePet(pet2);
student1.UsePetAbility(pet1);