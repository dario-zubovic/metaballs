# Unity 3D metaballs
Unity 3D implementation of marching cubes algorithm for rendering metaballs. Metaballs can be used for gameplay purposes (gels in Valve's Portal 2), or as a decoration, as shown in the image below. They can also be used to visualise various fields in physics (for example, each metaball can represent single point charge, and electrostatic potetial due to point charge equation can be used as a falloff function).

![](https://github.com/dario-zubovic/metaballs/raw/master/gif.gif)

Metaball functions are envaluated on either GPU or CPU. GPU mode performs about 10x faster than CPU. Currently there is only one falloff functions available:

```f(d) = r^2 / d^2```

Where *r* is radius of the metaball, and *d* is distance from metaball's center to current point. Additional functions can be quickly added as a new compute shader.

## TODO list:
* add more falloff functions
* move marching cubes algorithm to GPU
* create example scene with rigidbody metaballs

## References:
* William E. Lorensen and Harvey E. Cline. 1987. Marching cubes: A high resolution 3D surface construction algorithm. In Proceedings of the 14th annual conference on Computer graphics and interactive techniques (SIGGRAPH '87), Maureen C. Stone (Ed.). ACM, New York, NY, USA, 163-169.
* Marching cubes lookup tables taken from here: http://www.paulsprojects.net/opengl/metaballs/metaballs.html
* Brian Wyvill and Geoff Wyvill. Field functions for implicit surfaces. The Visual Computer, 5:75–82, December 1989.
