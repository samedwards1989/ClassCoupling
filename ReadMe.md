# Class Coupling

## Inheritance
- A kind of relationship between 2 classes that allows one to inherit code from the other.
- Referred to as 'Is A relationship': a car is a vehicle
- Pro's: code re-use and polymorphic behaviour

## Composition
- A kind of relationship that allows one class to contain another.
- Referred to as 'Has-A relationship': A Car has an Engine

## Example

In the Inheritance project we have a Car class and Plane class which both inherit from the Vehicle class.
The Vehicle class has 2 properties (NumberOfWheels and EngineSize) and has one method (Drive()).

The problem with both classes inheriting from Vehicle, is that a plane cannot drive.

In the Composition project

To overcome this we should use Composition, that way the Drive method should be moved to a seperate Drivable class,
the Car class can then re-use the code in the Drivable class and the Plane class would not.

We could then implement a Flyable class which the Plane class can re-use the code but the car would not.

## Favour Composition over Inheritance

### Problems with inheritance:
- Easily abused by amateur designers / developers
- Leads to large complex hierarchies
- Such hierarchies are very fragile and a change may affect many classes
- Results in tight coupling
- Benefits of composition:
- Flexible
- Leads to loose coupling
- Having said all that, it doesn’t mean inheritance should be avoided at all times. In fact,
it’s great to use inheritance when dealing with very stable classes on top of small
hierarchies. As the hierarchy grows (or variations of classes increase), the hierarchy,
however, becomes fragile. And that’s where composition can give you a better design.
