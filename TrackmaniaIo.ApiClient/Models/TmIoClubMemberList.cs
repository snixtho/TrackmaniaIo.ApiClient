﻿namespace TrackmaniaIo.ApiClient.Models;

public class TmIoClubMemberList
{
    public int Page { get; set; }
    public int PageMax { get; set; }
    public IEnumerable<TmIoClubMember>? Members { get; set; }
}