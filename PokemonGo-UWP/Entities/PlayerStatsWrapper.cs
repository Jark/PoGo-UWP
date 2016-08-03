using System.ComponentModel;
using Google.Protobuf;
using POGOProtos.Data.Player;

namespace PokemonGo_UWP.Entities
{
    public class PlayerStatsWrapper : IUpdatable<PlayerStats>, INotifyPropertyChanged
    {
        private PlayerStats _playerStats;

        public PlayerStatsWrapper(PlayerStats playerStatus)
        {
            _playerStats = playerStatus;
        }

        public void Update(PlayerStats update)
        {
            _playerStats = update;

            OnPropertyChanged(nameof(Level));
            OnPropertyChanged(nameof(Experience));
            OnPropertyChanged(nameof(PrevLevelXp));
            OnPropertyChanged(nameof(NextLevelXp));
            OnPropertyChanged(nameof(KmWalked));
            OnPropertyChanged(nameof(PokemonsEncountered));
            OnPropertyChanged(nameof(UniquePokedexEntries));
            OnPropertyChanged(nameof(PokemonsCaptured));
            OnPropertyChanged(nameof(Evolutions));
            OnPropertyChanged(nameof(PokeStopVisits));
            OnPropertyChanged(nameof(PokeballsThrown));
            OnPropertyChanged(nameof(EggsHatched));
            OnPropertyChanged(nameof(BigMagikarpCaught));
            OnPropertyChanged(nameof(BattleAttackWon));
            OnPropertyChanged(nameof(BattleAttackTotal));
            OnPropertyChanged(nameof(BattleDefendedWon));
            OnPropertyChanged(nameof(BattleTrainingWon));
            OnPropertyChanged(nameof(BattleTrainingTotal));
            OnPropertyChanged(nameof(PrestigeRaisedTotal));
            OnPropertyChanged(nameof(PrestigeDroppedTotal));
            OnPropertyChanged(nameof(PokemonDeployed));
            OnPropertyChanged(nameof(PokemonCaughtByType));
            OnPropertyChanged(nameof(SmallRattataCaught));
        }

        #region Wrapped Properties

        public int Level => _playerStats.Level;
        public long Experience => _playerStats.Experience;
        public long PrevLevelXp => _playerStats.PrevLevelXp;
        public long NextLevelXp => _playerStats.NextLevelXp;
        public float KmWalked => _playerStats.KmWalked;
        public int PokemonsEncountered => _playerStats.PokemonsEncountered;
        public int UniquePokedexEntries => _playerStats.UniquePokedexEntries;
        public int PokemonsCaptured => _playerStats.PokemonsCaptured;
        public int Evolutions => _playerStats.Evolutions;
        public int PokeStopVisits => _playerStats.PokeStopVisits;
        public int PokeballsThrown => _playerStats.PokeballsThrown;
        public int EggsHatched => _playerStats.EggsHatched;
        public int BigMagikarpCaught => _playerStats.BigMagikarpCaught;
        public int BattleAttackWon => _playerStats.BattleAttackWon;
        public int BattleAttackTotal => _playerStats.BattleAttackTotal;
        public int BattleDefendedWon => _playerStats.BattleDefendedWon;
        public int BattleTrainingWon => _playerStats.BattleTrainingWon;
        public int BattleTrainingTotal => _playerStats.BattleTrainingTotal;
        public int PrestigeRaisedTotal => _playerStats.PrestigeRaisedTotal;
        public int PrestigeDroppedTotal => _playerStats.PrestigeDroppedTotal;
        public int PokemonDeployed => _playerStats.PokemonDeployed;
        public ByteString PokemonCaughtByType => _playerStats.PokemonCaughtByType;
        public int SmallRattataCaught => _playerStats.SmallRattataCaught;

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}