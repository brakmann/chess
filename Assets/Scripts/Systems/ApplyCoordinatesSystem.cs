using Leopotam.EcsLite;

namespace Client {
    sealed class ApplyCoordinatesSystem : IEcsRunSystem {        
        private readonly EcsWorld _world;
        private EcsFilter _filter = null;
        private EcsPool<Coordinate> _coordinates;

        public void Run (IEcsSystems systems) {
            _filter = _world.Filter<Coordinate>().End();
            _coordinates = _world.GetPool<Coordinate>();
            foreach (int entity in _filter) {
                ref Coordinate coordinate = ref _coordinates.Get(entity);
                coordinate.x = 1;
                coordinate.y = 1;
            }
        }
    }
}