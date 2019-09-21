# C Sharp- OOP Basic LAB 
## **DEFINING CLASSES**
### **Problem 1**  
#### _**BankAccount**_
> _**NOTE:**_ Createing a **StartUp**_ class with the namescape _**BankAccount**_.  

Create a _**class**_ named _**BankAccount**_.  
The class should have _**private fields** for:
* id : int
* balance : eciaml
The class should also have _**public properties**_ for:
* Id : int
* Balance : decimal

### **Solution of Problem 1.
To solve **Problem 1**, we followed the following step:   
1. Create a classed named **BankAccount** contains:  
    * Private fields for these properties:  
      * id: int  
      * balance: decimal   
   The source code shown in the following figure:  
   ![The source code](https://i.imgur.com/V7lQYue.png)
    * Public fields for these properties:  
      * Id: int
      * Balance: decimal  
    The source code shown in the following figure:  
    ![The source code 1](https://i.imgur.com/DbSKw99.png)  
2. Create a new account and print its id and balance that shown in the following figure:
   ![Imgur](https://i.imgur.com/16bmytE.png)  

**The Result of Problem 1**  
![Imgur](https://i.imgur.com/WDuOava.png)  

# 
### **Problem 02** -  _Bank Account Method_  
To solve this problem, we followed these following step, contain:  
> **NOTE :** We using the _**BankAccount** class_ of the _**Problem 1**_. The source code that presented as the following figure.    
> ![Imgur](https://i.imgur.com/V7lQYue.png)  
> ![Imgur](https://i.imgur.com/wiHjAwA.png)  
1. With using the _**BankAccount** class_ that we created before, we also added some properties that required, include:  
* Deposit (decimal amount): void
* Withdrawl (decimal amout): void  
  According the source code that shown as the below figure.  
  ![Imgur](https://i.imgur.com/lUFzv4k.png)
  > _**Note:**_  
  > In this source code we declare _**amount**_ variable is decimal. In _**Deposit**_ if the value of a mount is greater then 0, the balance will plus amount. Otherwise, in _**Withdrawl**_, if the value of amount is smaller or equal the value of balance, the value of balance equal the value of amount, else the value of balance equal the value of balance minus the value of amount.  

2. We overrided the method ToString() to display the information of an account, include _**id**_ and _**balance**_. 
   ![Imgur](https://i.imgur.com/OLwLKrF.png)   
3. Then, we created new object that inherit the properties from _**BankAccount**_ class.  
   ![Imgur](https://i.imgur.com/aQSxR1x.png)  
4. Next, we set the value for objects, follwing the source code shown in the following figure.  
   ![Imgur](https://i.imgur.com/g1JRUbT.png)
5. Finally, we call ToSting() method to display the information of a account that we created in step 3 and 4.  
   ![Imgur](https://i.imgur.com/u8x1ING.png)
### **The result of source code**  
![Imgur](https://i.imgur.com/9IZKt9g.png)

#
## **Problem 3**
Create a test client that tests _**BankAccount**_ class.  
Support the _**following commands**_:  
  * Create{Id}
  * Deposit {Id} {amount}
  * Withdraw {Id} {amount}
  * Print {Id}
  * End  
If you try to create an account with an existing Id, print **"Account alreadly exists"**.  
If you try to perform an operation on a **non-existing account**, print **"Account does not exist."**.
If you try to withdraw an amount larger than the balance, print **"Insufficient balance"**.  
The _**Print command**_ should print **"Account ID{id}, balance {balance}"**. Round the balance to the second digit after the decimal separator.  

## **Solution**
1. Firstly, we reused the class _**BankAccount**_ that we created in the previous problem.
2. Next, created a _**Dictionary`<int, BankAccount>**_ to store existing accounts.  
    ![Imgur](https://i.imgur.com/P6Fm78J.png)  
3. Finally, using the _**While**_ loop and _**Switch**_ statement  to support the command that the problem required. The following figure is shown a piece of the source code in class _**Program**_.  
   ![Imgur](https://i.imgur.com/yP5fB6G.png)  

## **Input and Ouput**
 **Input** | **Output**  
------------|------------
 Create 1  | Account already exitss.
 Create 1 |  Insufficient balance.
 Deposit 1 20 | Account ID1, balance 10.00
 Withdraw 1 30 | 
 Withdraw 1 10 |
 Print 1 |
 -----------------|-------------------------------
 Deposit 2 20 | Account does not exists.
 Withdraw 2 30 | Account does not exists.
 Print 2 | Account doeas not exists.
 End |

## **The result of Source code**
![Imgur](https://i.imgur.com/IdxwCo7.png)  
![Imgur](https://i.imgur.com/jrF8l5o.png)

#
> _**NOTE:**_ We created a namescape _**AP_Lab01_Problem4**_ in each class.
## Problem 04- _Create a Person Class_
We create a sub-class  with a name is _**Person.cs**_, it contains:
* The private fiels for the following properties:  
  * name: string  
  * age : int
  * accounts: List`<BankAccount>`
* The class also have constructors:  
  * Person(string name, int age)  
  * Person(string name, int age, List`<BankAccount>` accounts)
* The class also have the following public method:
  * GetBalance(): decimal
## **Solution**  
1. Created the private fields for these properties that mentions on the requirement of the _**Problem04**_  
   ![Imgur](https://i.imgur.com/eaPIGAJ.png)  
2. Added the constructors into the _**Person.cs**_ class  
   ![Imgur](https://i.imgur.com/DbSKw99.png)
3. Created the public method for _**GetBalance(): decimal**_ into _**Person.cs**_ class  
   ![Imgur](https://i.imgur.com/2dyI1WL.png)
4. Used the _**BankAccount**_ class that created in previously problem in _**Lab01**_. Howerver, we added the namescape _**AP_Lab01_Problem4**_ for this class.
5. In _**Program.cs**_, we called _**BankAccount**_ class to create new account, and called GetBalance() method to display the information of the account that created, beside that we create new objects by using _**Person**_ class.  
   ![Imgur](https://i.imgur.com/jx1kg8U.png)

   #
# **ENCAPSULATION**
## **Problem1**
### **_Sort Persons by Name and Age_**

> _**NOTE:**_ _WE created 2 classes, include **Person.cs** and **Program.cs**, both of classes contains namescape **PersonInfo** as presented in the following figure._ 
> ![Imgur](https://i.imgur.com/M0GV55g.png)  
> ![Imgur](https://i.imgur.com/oJUiSqd.png)  
In the class _**Person**_, which should have private fields for:
* firstName: string
* lastName: string
* age: int
* ToString(): string - override

## **Solution**
1. Created class _**Person**_ class that contain the declare for firstName, lastName, age in private fields.  
   ![Imgur](https://i.imgur.com/EblALVe.png)  

2. Netx, we create the constructor for properties and created ToString() method  
   ![Imgur](https://i.imgur.com/Gd7URsl.png)
   
3. In class _**Program**_, we declared _**line**_ variable with type of value is integer. Then, we created a List with name is _**person**_ and created a _**for loop**_ to input the information of the person and sort the person by their name and eye via using _**Sorting Operator**_, inculde _**OrderBy**_ for FirstName and _**ThenBy**_ for Age.  
   ![Imgur](https://i.imgur.com/EQ771Vn.png)  
## **The result**
1. **Input and Output**  
    **Input** | **Output**
   ---------- |-----------
   5          | Asen Harizon is 44 years old.
   Asen Ivanov 65 | Asen Ivanov is 65 years old.
   Boiko Borisov 57 | Boiko Angelov is 35 years old.
   Vensislav Ivanov 27 | Boiko Borison is 57 years old.
   Asen Harizanov 44 | Vensislav Ivanov is 27 years old.
   Boiko Angelov 35 |  
   

2. **The result of source code**
   ![Imgur](https://i.imgur.com/hCzjlZf.png)
#
## **Problem 02**
### _**Salary Increase**_
>  _**NOTE:**_ Create a public _**Startup**_ class with the namescape _**PersonInfo**_.   
 
**Refactor the project from the last task.**  
Read a _**Person**_ with their names, age and salary. Read the percentage of the bonus to every Person salary. People younger than 30 _**get half the increase**_. Expand **Person** from the previous task.
New **fields** and **methods**:  
* salary: decimal
* IncreaseSalary(decimal percentage)  

## **Inputs and Outputs**  
**Input** | **Output**
----------|-----------
5         | Asen Ivanov receives 2640.00 leva.
Asen Ivanov 65 2200 | Boiko Borisov receives 3999.60 leva.
Boiko Borisov 57 3333 | Ventsislav Ivanov receives 600.00 leva.
Ventsislav Ivanov 27 600 | Asen Harizanoov receives 799.99 leva.
Boiko Angelov 35 559.4 | 
20 |

## **Solution**
1. Using the _**Person class**_ that created in the previous problem.  
2. Adding a new _**private**_ field for salary and _**refactor constructor**_, which will update salary with a bonus into the _**Person class**_. 
   ![Imgur](https://i.imgur.com/fvgsAGP.png) 
   ![Imgur](https://i.imgur.com/OiIDuno.png)  
3. Refactor the _**ToString() method for this problem.  
   ![Imgur](https://i.imgur.com/fY7d6Nm.png)  
4. In _**Program class**_, we using _**List**_ to contain the Person objects.
   ![Imgur](https://i.imgur.com/V2H5IgU.png)    
5. Using the _**for**_ loops to create the new objects that contained by _**List**_.  
   ![Imgur](https://i.imgur.com/4zJ4p4O.png)
6. Calling _**IncreaseSalary**_ method to calculate the salary for each person.
   ![Imgur](https://i.imgur.com/f7yHHw4.png)  

## **The result**
![Imgur](https://i.imgur.com/M6vEpUH.png)
#
## **Problem 03**
### _**Validation of Data**_
> _**NOTE:**_ Creating a public **Startup** class with the namescape **PersonInfo**.    
Expand _**Person**_ with proper validation for every field:
* Names must be at least 3 symbols
* Age must not be zero or negative.
* Salary cannot be less than 460.0
Print proper messages to the user:
* "Age cannot be zero or a negative integer!"
* "First name cannot contain fewer tha 3 symbols!"
* "Last name cannot contain fewer than 3 symbols!"
* "Salary cannot be less than 460 leva!"
> Use Argument Exception to show the message that mentioned before.

## **Input and Output**
**Input** | **Output**
----------|-----------
5 | Age cannot be zero or a negative integer!
Asen Ivanov -6 2200 | First name cannot contain fewer than 3 symbols!  
B Borisov 57 3333 | Last name cannot contain fewer than 3 symbols!
Ventsislav Ivanov 27 600 | Salary cannot be less than 460 leval!
Asen H 44 666.66 | Ventsislav Ivanov gets 660.00 leva.
Boiko Agelov 35 300 |

## **Solution**
1. Using the _**Person**_ class which created in the previous tasks.
2. Adding validation to all the setters in _**Person**_ class. In the validation process, we used _**Creating and Throwing Excaptions**_ to indicate that error has occurred while running the program. Exception objects that describe an error are created and then thrown with the throw keyword. The runtime then searches for the most compatible exception handler.
   ![Imgur](https://i.imgur.com/oKeeCAe.png)  
   ![Imgur](https://i.imgur.com/xUBNdjy.png)  
   ![Imgur](https://i.imgur.com/Utdg1Cf.png)
   ![Imgur](https://i.imgur.com/upqKd4r.png)  

3. In _**Program**_ class, we using _** try and catch**_ to find the exception and handler that just display the message in the screen.When the throw statement is called from inside _**Person class**_, the system looks for the catch statement and displays the message Exception caught.  
  ![Imgur](https://i.imgur.com/vQjqvGt.png)

## **The result**
![Imgur](https://i.imgur.com/sQSEuvT.png)
#
## **Problem 04**
### _**First and Reserve Team**_
> _**NOTE:**_ Creating a public _**Startup**_ class with the namescape _**PersonInfo**_.  
Create s _**Team**_ class. Add to this team all of the people you have received. Those who are younger than 40 go to the first team, others fo to the reserve team. At the end print the sizes of the first and the reserved team.  
The class should have _**private fiels**_ for:
* name : string  
* firstTeam : List`<Person>`
* reserveTeam: List`<Person>`  

The class should have _**constructors**_:
* Team(string name)  

The class should also have _**public properties**_ for:
* FirstTeam : List`<Person>` (read only!)
* ReserveTeam : List `<Person>` (read only!)

And a method for adding players:
* AddPalyer(Person person): void  

## **Input and Output**
**Input** | **Output**
----------|-----------
5 | First team has 4 players.
Asen Ivanov 20 2200 | Reserve team has 1 players.
Boiko Borisov 57 3333 |
Ventsislav Ivanov 27 600 |
Grigor Dimitrov 25 666066 |
Boiko Angleov 35 555 |

## **Solution**
1. Using the _**Person**_ class that created in the previous tasks.
2. Adding a new class _**Team**_. Its fields and constructor shown as the following figure.
   ![Imgur](https://i.imgur.com/rZzqIWZ.png)  

3. Properties for FirstTeam and ReserveTeam have only getters. In this section, we using _**IReadOnlyCollection**_ to protect the data and this collection should be treated as immutable, and the client code shoukd onky read it, and not update it.
   ![Imgur](https://i.imgur.com/P5n0hQI.png)  
   
4. There will have method, which adds players to teams.
   ![Imgur](https://i.imgur.com/bofGeoE.png)  

5. Adding ToString() methods into _**Team**_ class.  
   ![Imgur](https://i.imgur.com/vh2uqyU.png)  
6. In the _**Program.cs**_, we create a new team with name _**GCD0819**_
   ![Imgur](https://i.imgur.com/VfSdRTU.png)  

7. Using _**for**_ loops to input the objects to the team and calling _**AddPlayers**_ method to classify. Besides that, within the loops we using the _**try..catch**_ statement to find the exceptions and handle this by show the messages.  
   ![Imgur](https://i.imgur.com/Prkg0H2.png)  

8. To display the sizes of both of team, we calling _**ToString()**_ method.
   ![Imgur](https://i.imgur.com/0yQYQK8.png)  

## **The result**
![Imgur](https://i.imgur.com/kEmIhBX.png) 

#

# **POLYMORPHISM**
## **Problem 1**
### **Math Operation**
> _**NOTE:**_ Creating a public _**StartUp**_ class with the namescape _**Operations**_.  
  
Create a class MathOperations, which should have 3 times method _**Add()**_. Method _**Add**_ has to be invoked with:
* Add(int, int): **int**
* Add(double, double, double): **double**
* Add(decimal, decimal, decimal): **decimal**

## **Examples Output**
|**Output** |
------------|
5 |
11 |
9.9 |

## **Solution**
1. Creating _**MathOperation**_ class shown as the following figure.  ![Imgur](https://i.imgur.com/10PpQXP.png)  
   
2. In the _**Program.cs**_, calling 3 times _**Add()**_ method. 
   ![Imgur](https://i.imgur.com/2OBsPFT.png)  

## **The result**
![Imgur](https://i.imgur.com/iZfhujn.png) 
#
## **Problem 02**
### _**Animals**_
> _**NOTE:**_ Creating a public _**StartUp**_ class with the namespace _**Animals**_.  

Create a class _**Animal**_, which holds two fields:
* name : string
* favouriteFood : string

Animal has one virtual method ExplainSelf(): string.  
You should add two new classes - _**Cat**_ and _**Dog**_. _**Override**_ the _**Explainself()**_ method by adding concrete animal soud on a new line.

## **Examples of Output**
|**Output**|
-----------|
I am Pesho and my favourite food is Whiskas | 
MEEOW |
I am Gosho and my favourite food is Meat |
 DJAAF |

## **Solution**
1. Create new folder with name _**Models**_ to contains the sub-class.
   ![Imgur](https://i.imgur.com/95JFurz.png)  

2. Create a class _**Animal**_ with holds two fields name and favouriteFood. This is a base class.
   ![Imgur](https://i.imgur.com/Xz1g4if.png)  

3. In this base class contain one virtual method _**ExplainSelf()**_.  
   ![Imgur](https://i.imgur.com/XVSaVKa.png)  

4. Adding two classes _**Cat**_ and _**Dog**_ into the _**Models**_ folder. Within both of the classes contain _**Override**_ the _**ExplainSelf()**_ method by adding concrete animal sound on a new line. Within the _**ExpainDelf**_ method, we using _**StringBuider**_ to expand the number of characters in the string (to add the sound of animal), and using _**StringBuider.Append(valueToAppend)**_ and _**AppendLine**_ - to append the passed value to the end of the current _**StringBuilder**_ objects.
      
   ![Imgur](https://i.imgur.com/3HKCHFj.png)  

   ![Imgur](https://i.imgur.com/VPbM0on.png)  

   ![Imgur](https://i.imgur.com/rpCpAhX.png)  


5. In the _**Program.cs**_, we adding using _**Models**_ folders on th refferences scape.
   ![Imgur](https://i.imgur.com/3ltGoMa.png)  
   
6. In the main program, we create a new cat and dog by calling the sub-class in _**Models**_ folders.
   ![Imgur](https://i.imgur.com/YeyOlaL.png)  

7. Finally, we called _**ExplainSelf()**_ method in _**Cat**_ class and _**Dog**_ class.
   ![Imgur](https://i.imgur.com/DxHlfWI.png)  
   #
   ## **Problem 03**
## **_Shapes_**
> _**NOTE:**_ Creating a public _**StartUp**_ class with the namescape _**Shapes**_.  

Create a class hierarchy, starting with _**abstract**_ class Shape:
* **Abstract methods** :
  * CalculatePerimeter(): double
  * CalculateArea(): double
* **Virtual methods**:
  * Draw(): string

Extend the Shape class with two children:
* **Rectangle**
* **Circle**

Ech of them need to have:
* **Fields:**
  *  height and width for Rectangle
  *  radius for circle
* **Encapsulation for these fields**
* ** A public constructor**
* **Concrete methods for calculations (perimeter and ares)**
* **Override methods for drawing**

## **Solution**
1. Create a folder with name **_Models_** to contain the sub-class.
2. Create _**Shape**_ class with two _**Abstract methods**_ (CalculatePerimeter() and CalculateArea) and one _**virtual methods**_(Draw()) shown as figure.  
   ![Imgur](https://i.imgur.com/hvIN0Px.png)  

3. Create two childrens of _**Shape**_ class are _**Rectangle**_ and _**Circle**_.
* In each class have public constuctors, concrete methods for calculation perimeter and area, and override methods for drawing.  
    * Rectangle  
    ![Imgur](https://i.imgur.com/5VOppk9.png)  
    * Circle  
    * ![Imgur](https://i.imgur.com/vfMYrgQ.png)  
* Within _**Rectangle**_ that contain height and width.  
  ![Imgur](https://i.imgur.com/fHCpNmL.png) 

* Within _**Circle**_ that contain radius.  
  ![Imgur](https://i.imgur.com/3tQnEZW.png)
   
