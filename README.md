# NeuronDotNet
NeuronDotNet is an open source tool to build and run AI applications
based on 'Artificial Neural Networks'. It is written in C# and is
compatible with the .NET platform.

This tool exploits the potentialities of object oriented design and
modular programming. The objective of the project is to support the
development of AI applications and also to support experimental
research in the field by providing a centralized framework for
creation, training and usage of different types of artificial neural
networks.

## Background
The original source code is located at
[sourceforge.net](https://sourceforge.net/projects/neurondotnet/),
but it looks like it has not been touch since 2008.  However, it
seems to work!  

## Samples
* [XOR Sample](Source/Samples/XOR%20Sample/XOR%20Sample/MainForm.cs)
* [Kohonen SOM Demo](Source/Samples/SOM%20Demo/Kohonen%20SOM%20Demo/MainForm.cs)
* [Function Approximation](Source/Samples/Function%20Approximation/Function%20Approximation/MainForm.cs)
* [Traveling Salesman Problem Solver](Source/Samples/TSP%20Solver/TSP%20Solver/MainForm.cs)

## Usage Examples
There are some Unity projects using this library:  
* [NeuralGames](https://github.com/tiagosomda/NeuralGames)

## Documentation
The only thing close to a documentation right now are the examples
and the source code itself.

## 	Release history
<details>

### NeuronDotNet 3.0
Release Date: August 20th, 2008

* Support for neural networks with any acyclic structure of layers
* One-One and Complete connectors are supported
* Backpropagation networks and Kohonen SOMs are supported
* Learning Rate changes from its initial value to a final value
  using a pluggable function:
  * Linear
  * Logarithmic
  * Hyperbolic

  are built in
* Neural network initialization modules are pluggable:
  * Random
  * Constant
  * NguyenWidrow
  * Normalized Random Functions
  
  are built in
* Custom activation funtions used in backpropagation networks
  are pluggable:
  * Sigmoid
  * sine
  * tanh
  * logarithmic
  * linear

  functions are built in
* For a Kohonen Layer, Neighborhood functions are pluggable:
  * Gaussian
  * mexican hat

  functions are built in
* Various events are exposed which allow users to analyse how
  a network learns
* Kohonen layers are planar in shape. However, we can have circular
  rows and/or columns which make them attain the shape of a cylindrical
  surface or a toroidal surface.
* Hexagonal and Rectangular Kohonen lattice topologies are supported
* Training set has been defined to support Batch Training
* API to add custom network architectures and learning algorithms
* Layers, connectors, networks and training sets implement
  ISerializable interface

### NeuronDotNet 2.0
Release Date: November 1st, 2007

* Backpropagation neural networks with any acyclic structure of layers
* Custom activation functions are pluggable
* Enhanced BackPropagation Algorithm
  (using Momentum term, Weight Decay and Jitter).
* OneOne and Complete connections between layers

### NeuronDotNet 1.0
Release Date: May 3rd, 2007

* First release
* Support for simple feed-forward backpropagation neural networks
* Activation functions - Sigmoid, Linear, Logarithminc, Sine or Tanh

</details>

## Other libraries
* [CNTK](https://github.com/Microsoft/CNTK)
* [TensorFlow](https://www.tensorflow.org/)
* [AForge.Net](http://www.aforgenet.com/)
