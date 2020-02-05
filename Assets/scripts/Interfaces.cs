namespace Interfaces {
    interface IDamageable {
        void Hit(int damage);
    }
    interface IWeapon {
        void Fire();
        void AltFire();
        int PrimaryClip { get; set; }
        int SecondaryClip { get; set; }
    }
}