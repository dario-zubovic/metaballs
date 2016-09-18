# Unity 3D metaballs
Unity 3D implementation of marching cubes algorithm for rendering metaballs. Metaballs can be used for gameplay purposes (gels in Valve's Portal 2), or as a decoration, as shown in the image below. They can also be used to visualise various fields in physics (for example, each metaball can represent single point charge, and electrostatic potetial due to point charge equation can be used as a falloff function).

![](https://github.com/dario-zubovic/metaballs/raw/master/gif1.gif)
![](https://github.com/dario-zubovic/metaballs/raw/master/gif2.gif)

Metaball functions are evaluated on GPU. Falloff functions can be chosen in the compute shader with a define statements. Marching cubes algorithm partially executes on GPU and partially on CPU.

Thanks to Filip Ugrin for providing 3d models for example scene!

## TODO list:
* ~~move marching cubes algorithm to GPU~~ partially moved marching cubes to compute shader, but there is still room for improvement
* implement some kind of subdivision smoothing algorithm
* create example scene with rigidbody metaballs
* create example scene with electric potential visualization

## References:
* William E. Lorensen and Harvey E. Cline. 1987. Marching cubes: A high resolution 3D surface construction algorithm. In Proceedings of the 14th annual conference on Computer graphics and interactive techniques (SIGGRAPH '87), Maureen C. Stone (Ed.). ACM, New York, NY, USA, 163-169.
* Marching cubes lookup tables taken from here: http://www.paulsprojects.net/opengl/metaballs/metaballs.html
* Brian Wyvill and Geoff Wyvill. Field functions for implicit surfaces. The Visual Computer, 5:75–82, December 1989.
