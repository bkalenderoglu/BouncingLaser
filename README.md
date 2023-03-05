# BouncingLaser

The Bouncing Laser is a popular game mechanic that requires a basic understanding of mathematics to develop. In this repo main goal was re-writing the build-in Reflect function.

## Mathematical Approach
Both d and n vectors are normalized. In other words, vectors have length of 1.
- d → laser vector
- n → normal vector of a hit point which is perpendicular to surface
- r → reflection vector through hit point

![](https://github.com/bkalenderoglu/BouncingLaser/blob/main/Assets/Images/Frame1.png)

It is important to recognize that, the way laser bounces does not depend on the world space position of where it hit or where it came from. The direction of the laser and the normal of the surface will be enough to calculate the reflection direction.

![](https://github.com/bkalenderoglu/BouncingLaser/blob/main/Assets/Images/Frame2.png)

There is a mirror symmetry between d and r vectors. We can use the dot product to project d vector along n vector and get signed distance p. Both vectors are normalized so, we can call it as a scalar projection.

![](https://github.com/bkalenderoglu/BouncingLaser/blob/main/Assets/Images/Frame3.png)

p value is going to be negative distance because, perpendicular projection of d vector is behind the normal vector. 

![](https://github.com/bkalenderoglu/BouncingLaser/blob/main/Assets/Images/Frame4.png)

To get reflected position we need to add vector to a d vector. At this point p is just a number, to have it as a vector, vector projection is applided by multiplying it by normal vector.

![](https://github.com/bkalenderoglu/BouncingLaser/blob/main/Assets/Images/Frame6.png)
