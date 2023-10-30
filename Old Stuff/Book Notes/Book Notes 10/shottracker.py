class ShotTracker:
    
    def __init__(self,win,angle,velocity,height):
        
        self.proj = Projectile(angle,velocity,height)
        self.marker = Circle(Point(0,height),3)
        self.marker.setFill('Red')
        self.marker.setOutline('Red')
        self.marker.draw(win)
        
    def update(self,dt):
        
        # Update the projectile
        self.proj.update(dt)
        
        # Move the circle to the new projectile location
        center = self.marker.getCenter()
        dx = self.proj.getX() - center.getx()
        dy = self.proj.getY() - center.getY()
        self.marker.move(dx,dy)
        
    def getX(self):
        return self.proj.getX()
    
    def getY(self):
        return self.proj.getY()
    
    def undraw(self):
        self.marker.undraw()