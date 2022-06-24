using Shouldly;
using TestBedConsole;
using Xunit;

namespace TestProject1;

public class RansomNoteTest
{
    [Fact]
    public void TestCanSpellWord()
    {
        var letters = new char[] {'a', 'b', 'c', 'd', 'e', 'f'};
        RansomNote.CanSpellWordBruteForce(letters, "cab").ShouldBe(true, "Must be able to spell cab");
        RansomNote.CanSpellWordBruteForce(letters, "bad").ShouldBe(true, "Must be able to spell bad");
        RansomNote.CanSpellWordBruteForce(letters, "fade").ShouldBe(true, "Must be able to spell fade");
        RansomNote.CanSpellWordBruteForce(letters, "bed").ShouldBe(true, "Must be able to spell bed");
        RansomNote.CanSpellWordBruteForce(letters, "deaf").ShouldBe(true, "Must be able to spell deaf");
        RansomNote.CanSpellWordBruteForce(letters, "cat").ShouldBe(false, "No way to spell cat");
    }
    
    [Fact]
    public void TestCanSpellWordHashed()
    {
        var letters = new char[] {'a', 'b', 'c', 'd', 'e', 'f'};
        RansomNote.CanSpellWordHashed(letters, "cab").ShouldBe(true, "Must be able to spell cab");
        RansomNote.CanSpellWordHashed(letters, "bad").ShouldBe(true, "Must be able to spell bad");
        RansomNote.CanSpellWordHashed(letters, "fade").ShouldBe(true, "Must be able to spell fade");
        RansomNote.CanSpellWordHashed(letters, "bed").ShouldBe(true, "Must be able to spell bed");
        RansomNote.CanSpellWordHashed(letters, "deaf").ShouldBe(true, "Must be able to spell deaf");
        RansomNote.CanSpellWordHashed(letters, "cat").ShouldBe(false, "No way to spell cat");
    }
    
    [Fact]
    public void TestCanSpellWordTechLead()
    {
        var letters = new char[] {'a', 'b', 'c', 'd', 'e', 'f'};
        RansomNote.CanSpellWordHashed(letters, "cab").ShouldBe(true, "Must be able to spell cab");
        RansomNote.CanSpellWordHashed(letters, "bad").ShouldBe(true, "Must be able to spell bad");
        RansomNote.CanSpellWordHashed(letters, "fade").ShouldBe(true, "Must be able to spell fade");
        RansomNote.CanSpellWordHashed(letters, "bed").ShouldBe(true, "Must be able to spell bed");
        RansomNote.CanSpellWordHashed(letters, "deaf").ShouldBe(true, "Must be able to spell deaf");
        RansomNote.CanSpellWordHashed(letters, "cat").ShouldBe(false, "No way to spell cat");
    }
}