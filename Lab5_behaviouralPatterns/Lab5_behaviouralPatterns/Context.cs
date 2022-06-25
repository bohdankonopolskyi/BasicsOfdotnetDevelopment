using System;
namespace Lab5_behaviouralPatterns
{
    // The Context class defines the interface of interest to sprites.
    public abstract class Sprite
    {

        protected IMovable _motion;

        public int CurrentPosition { get; internal set; }
        public int Speed { get; internal set; }

        public Sprite()
        {
        }

        public Sprite(IMovable motion)
        {
            this._motion = motion;
        }

        // method for shifting motion type at runtime
        public virtual void SetMotionType(IMovable movable)
        {


            this._motion = movable;

        }

        // sprite motion
        public virtual string Move()
        {
            return _motion.Move();
        }

        // method for adding new sprites to group
        public virtual void Add(Sprite sprite)
        {
            throw new NotImplementedException();
        }

        // method for removing new sprites to group
        public virtual void Remove(Sprite sprite)
        {
            throw new NotImplementedException();
        }


        public virtual bool IsGroup()
        {
            return true;
        }
    }
}

