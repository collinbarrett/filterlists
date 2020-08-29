﻿export interface ListDetails {
  id: number;
  name: string;
  description: string;
  licenseId: number;
  syntaxIds: number[];
  languageIso6391s: number[];
  tagIds: number[];
  viewUrls: unknown[];
  homeUrl: string;
  onionUrl: string;
  policyUrl: string;
  submissionUrl: string;
  issuesUrl: string;
  forumUrl: string;
  chatUrl: string;
  emailAddress: string;
  donateUrl: string;
  maintainerIds: number[];
  upstreamFilterListIds: number[];
  forkFilterListIds: number[];
  includedInFilterListIds: number[];
  includesFilterListIds: number[];
  dependencyFilterListIds: number[];
  dependentFilterListIds: number[];
}
