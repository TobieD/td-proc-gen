# Datamodel

The output data model will be created as a list of Features.
Each Feature will have:

- a 'Type', deciding how the data should be interpreted
- an 'Id', just to let it know what it is
- a list of 'coordinates'; these are x and y coordinates of the location in the map

Depending on the type of feature; extra data could be added (eg. width for roads, ...)
    