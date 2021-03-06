//brick1x3arch.cs


//Item
datablock ItemData(brick1x6x2arch : brick2x2)
{
	shapeFile = "~/data/shapes/bricks/brick1x6x2arch.dts";
	pickUpName = 'a 1x6x2 Arch';
	invName = '1x6x2 Arch';
	image = brick1x6x2archImage;
	cost = 6;
};

//Static Shape
datablock StaticShapeData(staticbrick1x6x2arch : staticBrick2x2)
{
	item = brick1x6x2arch;
	shapeFile = "~/data/shapes/bricks/brick1x6x2arch.dts";

	//lego scale dimensions
	x = 1;
	y = 1;
	z = 1;	//3 plates = 1 brick
};

//Image
datablock ShapeBaseImageData(brick1x6x2archImage : brick2x2Image)
{
	staticShape = staticbrick1x6x2arch;
	PreviewFileName = "rtb/data/shapes/bricks/Previews/brick1x6x2arch.png";
	item = brick1x6x2arch;
};
