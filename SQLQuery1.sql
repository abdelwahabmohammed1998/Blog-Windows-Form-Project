-- World News
INSERT INTO Catalogs (name, description) VALUES ('World News', 'International events, politics, conflicts, and diplomatic relations.');

-- National News
INSERT INTO Catalogs (name, description) VALUES ('National News', 'News from within a specific country, covering politics, economy, and social issues.');

-- Business and Finance
INSERT INTO Catalogs (name, description) VALUES ('Business and Finance', 'Updates on the financial markets, business developments, economic trends, and corporate news.');

-- Technology
INSERT INTO Catalogs (name, description) VALUES ('Technology', 'Innovations, product launches, cybersecurity, and updates from the tech industry.');

-- Science
INSERT INTO Catalogs (name, description) VALUES ('Science', 'Discoveries, breakthroughs, and advancements in various scientific fields.');

-- Health
INSERT INTO Catalogs (name, description) VALUES ('Health', 'Medical research, public health issues, and updates on healthcare policies.');

-- Environment
INSERT INTO Catalogs (name, description) VALUES ('Environment', 'News related to climate change, conservation efforts, and environmental policies.');

-- Entertainment
INSERT INTO Catalogs (name, description) VALUES ('Entertainment', 'Celebrity news, movie releases, music, and updates from the entertainment industry.');

-- Sports
INSERT INTO Catalogs (name, description) VALUES ('Sports', 'Scores, highlights, and news from various sports leagues and events.');

-- Politics
INSERT INTO Catalogs (name, description) VALUES ('Politics', 'Updates on political developments, elections, and government policies.');


-- User 1
INSERT INTO Authors (name, userName, age, password, joinDate) VALUES ('John Doe', 'john_doe123', 30, 'password123', '2022-03-09');

-- User 2
INSERT INTO Authors (name, userName, age, password, joinDate) VALUES ('Jane Smith', 'jane_smith456', 28, 'securepass456', '2022-03-09');

-- User 3
INSERT INTO Authors (name, userName, age, password, joinDate) VALUES ('Robert Johnson', 'rob_johnson789', 35, 'pass1234', '2022-03-10');

-- User 4
INSERT INTO Authors (name, userName, age, password, joinDate) VALUES ('Emily Davis', 'emily_davis10', 25, 'mypassword', '2022-03-10');

-- User 5
INSERT INTO Authors (name, userName, age, password, joinDate) VALUES ('Michael Wilson', 'mike_wilson22', 40, 'securepass789', '2022-03-11');




-- News 1
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Global Summit Addresses Climate Change', 'World leaders gather to discuss environmental challenges', 'Leaders from around the globe converge to find solutions for combating climate change.', '2022-03-12', 1, 7);

-- News 2
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('New Breakthrough in Medical Research', 'Scientists discover potential treatment for a rare disease', 'A team of researchers announces a groundbreaking discovery that could lead to a cure for a previously incurable disease.', '2022-03-13', 2, 6);

-- News 3
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Economic Boom Fuels Job Growth', 'Unemployment rates drop as economy sees record growth', 'Positive economic indicators lead to increased job opportunities and a decline in unemployment rates.', '2022-03-14', 3, 2);

-- News 4
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Space Exploration Mission Successful', 'Probe sends back data from distant planet', 'The latest space mission achieves success as a probe sends back valuable data from a distant and unexplored planet.', '2022-03-15', 4, 5);

-- News 5
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('New Movie Sweeps Awards Season', 'Critically acclaimed film takes home multiple awards', 'A cinematic masterpiece receives recognition and accolades at major film festivals, winning several prestigious awards.', '2022-03-16', 5, 8);

-- News 6
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Political Leaders Sign Historic Peace Agreement', 'Diplomatic breakthrough brings an end to long-standing conflict', 'After years of negotiations, political leaders sign a historic peace agreement, bringing hope for a lasting resolution.', '2022-03-17', 1, 1);

-- News 7
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('New Technology Promises Faster Internet Speeds', 'Innovative technology set to revolutionize internet connectivity', 'A breakthrough in technology is poised to provide users with significantly faster internet speeds, enhancing online experiences.', '2022-03-18', 2, 4);

-- News 8
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Major Sporting Event Draws Global Audience', 'Top athletes compete on the world stage', 'The world comes together to witness an exhilarating sporting event featuring top athletes competing for glory and recognition.', '2022-03-19', 3, 9);

-- News 9
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Artificial Intelligence Breakthrough in Healthcare', 'AI system shows remarkable accuracy in medical diagnoses', 'Researchers unveil an AI system that demonstrates unprecedented accuracy in diagnosing medical conditions, potentially revolutionizing healthcare.', '2022-03-20', 4, 6);

-- News 10
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('New Environmental Policies Aimed at Conservation', 'Government introduces measures to protect natural habitats', 'Authorities announce a series of new environmental policies with the goal of preserving and protecting natural ecosystems.', '2022-03-21', 5, 7);

-- News 11
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Celebrity Couple Announces Engagement', 'Hollywood power couple set to tie the knot', 'A beloved celebrity couple makes headlines by announcing their engagement, sparking excitement among fans and the media.', '2022-03-22', 1, 8);

-- News 12
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('New Smartphone Release Anticipated', 'Tech enthusiasts eagerly await the latest device', 'Leading tech company teases the launch of its highly anticipated smartphone, generating buzz and anticipation among consumers.', '2022-03-23', 2, 4);

-- News 13
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Breakthrough in Renewable Energy Technology', 'Innovative solution promises sustainable energy', 'Scientists announce a groundbreaking discovery in renewable energy technology, offering a sustainable solution to power needs.', '2022-03-24', 3, 7);

-- News 14
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Historical Landmark Restoration Project', 'Efforts underway to preserve cultural heritage', 'A significant historical landmark is undergoing restoration efforts to preserve its cultural significance and architectural beauty.', '2022-03-25', 4, 1);

-- News 15
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Fashion Week Showcases Latest Trends', 'Designers unveil cutting-edge fashion creations', 'Fashion enthusiasts and industry insiders gather to witness the latest trends and innovations showcased during a prestigious fashion week event.', '2022-03-26', 5, 8);

-- News 16
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Advancements in Artificial Intelligence', 'AI researchers achieve significant milestones', 'The field of artificial intelligence experiences notable progress as researchers achieve key milestones in the development of advanced AI systems.', '2022-03-27', 1, 4);

-- News 17
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('International Collaboration in Scientific Research', 'Scientists from multiple countries join forces', 'A collaborative effort between researchers from different nations leads to groundbreaking discoveries in scientific research.', '2022-03-28', 2, 6);

-- News 18
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Space Tourism Company Announces Maiden Voyage', 'Private company set to launch commercial space travel', 'In a major milestone for space tourism, a private company reveals plans for its inaugural commercial space travel mission.', '2022-03-29', 3, 5);

-- News 19
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Innovative Educational Program Aims to Bridge Gaps', 'Initiative seeks to enhance learning opportunities', 'A new educational program is introduced with the goal of providing innovative learning experiences and closing educational gaps.', '2022-03-30', 4, 2);

-- News 20
INSERT INTO News (title, bref, description, date, authorId, catalogId)
VALUES ('Major Art Exhibition Celebrates Diverse Creativity', 'Artists from various backgrounds showcase their work', 'A prominent art exhibition features a diverse collection of artworks, highlighting the creativity and talent of artists from around the world.', '2022-03-31', 5, 8);


DBCC CHECKIDENT ('[News]', RESEED, 0); --Reset Table Identity
