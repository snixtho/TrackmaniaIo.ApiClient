using TrackmaniaIo.ApiClient.Models.Events;

namespace TrackmaniaIo.ApiClient.Resources;

/// <summary>
/// Events and competitions
/// </summary>
public class CompetitionResource : TmIoApiBase<CompetitionResource>
{
    public CompetitionResource(string projectName, string contact, string? apiKey = null) : base(projectName, contact, apiKey)
    {
    }

    /// <summary>
    /// Get a list of current events/competitions.
    /// </summary>
    /// <returns></returns>
    public Task<TmIoCompetitionList?> GetCompetitionListAsync() =>
        WithApiKey()
            .GetJsonAsync<TmIoCompetitionList>("/competitions/0");

    /// <summary>
    /// Get info about a competition.
    /// </summary>
    /// <param name="id">ID of the competition.</param>
    /// <returns></returns>
    public Task<TmIoCompetitionInfo?> GetCompetitionAsync(int id) =>
        WithApiKey()
            .GetJsonAsync<TmIoCompetitionInfo>("/comp/{id}", id);

    /// <summary>
    /// Get match results of a competition.
    /// </summary>
    /// <param name="compId">ID of the competition</param>
    /// <param name="matchId">ID of the match</param>
    /// <param name="offset">Offset from position 0 in the results</param>
    /// <returns></returns>
    public Task<TmIoCompetitionResult?> GetMatchResultsAsync(int compId, int matchId, int offset = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoCompetitionResult>("/comp/{compId}/match/{matchId}/{offset}", compId, matchId, offset);

    /// <summary>
    /// Get information about a challenge within a competition.
    /// </summary>
    /// <param name="compId">ID of the competition</param>
    /// <param name="challengeId">ID of the challenge</param>
    /// <returns></returns>
    public Task<TmIoCompetitionChallengeInfo?> GetChallengeInfo(int compId, int challengeId) =>
        WithApiKey()
            .GetJsonAsync<TmIoCompetitionChallengeInfo>("/comp/{compId}/challenge/{challengeId}", compId, challengeId);
    
    /// <summary>
    /// Get results of a challenge within a competition.
    /// </summary>
    /// <param name="compId">Id of the competition</param>
    /// <param name="challengeId">Id of the challenge</param>
    /// <param name="offset">Offset from position 0 in the results</param>
    /// <returns></returns>
    public Task<TmIoCompetitionResult?> GetChallengeResultsAsync(int compId, int challengeId, int offset = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoCompetitionResult>("/comp/{compId}/challenge/{challengeId}/{offset}", compId, challengeId,
                offset);
}